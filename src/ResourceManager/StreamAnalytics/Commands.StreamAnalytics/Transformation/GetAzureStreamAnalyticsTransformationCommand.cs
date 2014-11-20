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

using System.Collections.Generic;
using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.Azure.Commands.StreamAnalytics.Models;

namespace Microsoft.Azure.Commands.StreamAnalytics
{
    [Cmdlet(VerbsCommon.Get, Constants.StreamAnalyticsTransformation), OutputType(typeof(List<PSTransformation>), typeof(PSTransformation))]
    public class GetAzureStreamAnalyticsTransformationCommand : StreamAnalyticsResourceProviderBaseCmdlet
    {
        [Parameter(ParameterSetName = SingleStreamAnalyticsObject, Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The azure stream analytics job name.")]
        [ValidateNotNullOrEmpty]
        public string JobName { get; set; }

        [Parameter(ParameterSetName = SingleStreamAnalyticsObject, Position = 2, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The azure stream analytics transformation name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            if (ResourceGroupName != null && string.IsNullOrWhiteSpace(ResourceGroupName))
            {
                throw new PSArgumentNullException("ResourceGroupName");
            }

            if (JobName != null && string.IsNullOrWhiteSpace(JobName))
            {
                throw new PSArgumentNullException("JobName");
            }

            if (Name != null && string.IsNullOrWhiteSpace(Name))
            {
                throw new PSArgumentNullException("Name");
            }

            PSTransformation transformation = StreamAnalyticsClient.GetTransformation(ResourceGroupName, JobName, Name);
            WriteObject(transformation);
        }
    }
}