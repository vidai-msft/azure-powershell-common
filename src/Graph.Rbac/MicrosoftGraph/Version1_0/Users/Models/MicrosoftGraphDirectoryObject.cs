// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Users.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftGraphDirectoryObject : MicrosoftGraphEntity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphDirectoryObject
        /// class.
        /// </summary>
        public MicrosoftGraphDirectoryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphDirectoryObject
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        public MicrosoftGraphDirectoryObject(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), System.DateTime? deletedDateTime = default(System.DateTime?))
            : base(additionalProperties, id)
        {
            DeletedDateTime = deletedDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedDateTime")]
        public System.DateTime? DeletedDateTime { get; set; }

    }
}
