// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.DirectoryObjects.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Body
    {
        /// <summary>
        /// Initializes a new instance of the Body class.
        /// </summary>
        public Body()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Body class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public Body(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<string> ids = default(IList<string>), IList<string> types = default(IList<string>))
        {
            AdditionalProperties = additionalProperties;
            Ids = ids;
            Types = types;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ids")]
        public IList<string> Ids { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public IList<string> Types { get; set; }

    }
}
