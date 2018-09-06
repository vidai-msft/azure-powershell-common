﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Common.Authentication.Test.Cmdlets;
using Hyak.Common;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Factories;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Internal.Subscriptions;
using Microsoft.Azure.Internal.Subscriptions.Models;
using Microsoft.Rest;
using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Security;
using Xunit;

namespace Common.Authentication.Test
{
    public class LoginTests
    {
        private ConnectAccount _cmdlet;
        private IAzureAccount _account;

        // Global test variables
        private string _tenantId = null;
        private string _subscriptionId = null;
        private string _subscriptionName = null;
        private string _userName = null;
        private string _password = null;

        public LoginTests()
        {
            AzureSessionInitializer.InitializeAzureSession();
            ResourceManagerProfileProvider.InitializeResourceManagerProfile();

            ContextAutosaveSettings settings = null;
            AzureSession.Modify((session) => EnableAutosave(session, true, out settings));
            ProtectedProfileProvider.InitializeResourceManagerProfile(true);

            _cmdlet = new ConnectAccount();
            _cmdlet.TenantId = _tenantId;
            _cmdlet.SubscriptionId = _subscriptionId;
            _cmdlet.SubscriptionName = _subscriptionName;
            _cmdlet.UserName = _userName;
            _cmdlet.Password = _password;
            _cmdlet.CommandRuntime = new MockCommandRuntime();
        }

        private void Login()
        {
            _cmdlet.Account = _account;
            _cmdlet.InvokeBeginProcessing();
            _cmdlet.ExecuteCmdlet();
            _cmdlet.InvokeEndProcessing();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.LiveOnly)]
        public void LoginWithUsernameAndPassword()
        {
            _account = new AzureAccount() { Type = AzureAccount.AccountType.User };
            Login();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.LiveOnly)]
        public void LoginWithServicePrincipal()
        {
            // REQUIRED:
            // _tenantId --> Id of the tenant that the service princinpal is registered to
            // _userName --> Application id of the service principal
            // _password --> Secret of the service principal
            _account = new AzureAccount() { Type = AzureAccount.AccountType.ServicePrincipal };
            Login();
        }

        private void EnableAutosave(IAzureSession session, bool writeAutoSaveFile, out ContextAutosaveSettings result)
        {
            var store = session.DataStore;
            string contextPath = Path.Combine(session.ARMProfileDirectory, session.ARMProfileFile);
            string tokenPath = Path.Combine(session.TokenCacheDirectory, session.TokenCacheFile);
            if (!IsValidPath(contextPath))
            {
                throw new PSInvalidOperationException(string.Format("'{0}' is not a valid path. You cannot enable context autosave without a valid context path", contextPath));
            }

            if (!IsValidPath(tokenPath))
            {
                throw new PSInvalidOperationException(string.Format("'{0}' is not a valid path. You cannot enable context autosave without a valid token cache path", tokenPath));
            }

            result = new ContextAutosaveSettings
            {
                CacheDirectory = session.TokenCacheDirectory,
                CacheFile = session.TokenCacheFile,
                ContextDirectory = session.ARMProfileDirectory,
                ContextFile = session.ARMProfileFile,
                Mode = ContextSaveMode.CurrentUser
            };

            FileUtilities.DataStore = session.DataStore;
            session.ARMContextSaveMode = ContextSaveMode.CurrentUser;
            var diskCache = session.TokenCache as ProtectedFileTokenCache;
            try
            {
                if (diskCache == null)
                {
                    var memoryCache = session.TokenCache as AuthenticationStoreTokenCache;
                    try
                    {
                        FileUtilities.EnsureDirectoryExists(session.TokenCacheDirectory);

                        diskCache = new ProtectedFileTokenCache(tokenPath, store);
                        if (memoryCache != null && memoryCache.Count > 0)
                        {
                            diskCache.Deserialize(memoryCache.Serialize());
                        }

                        session.TokenCache = diskCache;
                    }
                    catch
                    {
                        // leave the token cache alone if there are file system errors
                    }
                }

                if (writeAutoSaveFile)
                {
                    try
                    {
                        FileUtilities.EnsureDirectoryExists(session.ProfileDirectory);
                        string autoSavePath = Path.Combine(session.ProfileDirectory, ContextAutosaveSettings.AutoSaveSettingsFile);
                        session.DataStore.WriteFile(autoSavePath, JsonConvert.SerializeObject(result));
                    }
                    catch
                    {
                        // do not fail for file system errors in writing the autosave setting
                    }

                }
            }
            catch
            {
                // do not throw if there are file system error
            }
        }

        private bool IsValidPath(string path)
        {
            FileInfo valid = null;
            try
            {
                valid = new FileInfo(path);
            }
            catch
            {
                // swallow any exception
            }
            return valid != null;
        }
    }
}
