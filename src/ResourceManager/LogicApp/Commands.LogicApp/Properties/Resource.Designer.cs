﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.LogicApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.LogicApp.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Web/serverfarms/{2}.
        /// </summary>
        internal static string ApplicationServicePlanIdFormat {
            get {
                return ResourceManager.GetString("ApplicationServicePlanIdFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Definition content needs to be specified..
        /// </summary>
        internal static string DefinitionMissingWarning {
            get {
                return ResourceManager.GetString("DefinitionMissingWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} does not exist..
        /// </summary>
        internal static string FileDoesNotExist {
            get {
                return ResourceManager.GetString("FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} needs to be specified..
        /// </summary>
        internal static string ParameterNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("ParameterNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing logic app..
        /// </summary>
        internal static string RemoveLogicAppMessage {
            get {
                return ResourceManager.GetString("RemoveLogicAppMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the logic app &quot;{0}&quot;..
        /// </summary>
        internal static string RemoveLogicAppWarning {
            get {
                return ResourceManager.GetString("RemoveLogicAppWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Resource &apos;Microsoft.Logic/workflows/{0}&apos; under resource group &apos;{1}&apos; already exists..
        /// </summary>
        internal static string ResourceAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Resource &apos;Microsoft.Logic/workflows/{0}&apos; under resource group &apos;{1}&apos; was not found..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
    }
}
