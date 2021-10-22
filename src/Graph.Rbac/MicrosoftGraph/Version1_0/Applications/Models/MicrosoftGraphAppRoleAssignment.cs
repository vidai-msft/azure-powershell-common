// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftGraphAppRoleAssignment : MicrosoftGraphDirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphAppRoleAssignment
        /// class.
        /// </summary>
        public MicrosoftGraphAppRoleAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphAppRoleAssignment
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="appRoleId">The identifier (id) for the app role which
        /// is assigned to the principal. This app role must be exposed in the
        /// appRoles property on the resource application's service principal
        /// (resourceId). If the resource application has not declared any app
        /// roles, a default app role ID of
        /// 00000000-0000-0000-0000-000000000000 can be specified to signal
        /// that the principal is assigned to the resource app without any
        /// specific app roles. Required on create.</param>
        /// <param name="createdDateTime">The time when the app role assignment
        /// was created.The Timestamp type represents date and time information
        /// using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// Read-only.</param>
        /// <param name="principalDisplayName">The display name of the user,
        /// group, or service principal that was granted the app role
        /// assignment. Read-only. Supports $filter (eq and
        /// startswith).</param>
        /// <param name="principalId">The unique identifier (id) for the user,
        /// group or service principal being granted the app role. Required on
        /// create.</param>
        /// <param name="principalType">The type of the assigned principal.
        /// This can either be User, Group or ServicePrincipal.
        /// Read-only.</param>
        /// <param name="resourceDisplayName">The display name of the resource
        /// app's service principal to which the assignment is made.</param>
        /// <param name="resourceId">The unique identifier (id) for the
        /// resource service principal for which the assignment is made.
        /// Required on create. Supports $filter (eq only).</param>
        public MicrosoftGraphAppRoleAssignment(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), System.DateTime? deletedDateTime = default(System.DateTime?), System.Guid? appRoleId = default(System.Guid?), System.DateTime? createdDateTime = default(System.DateTime?), string principalDisplayName = default(string), System.Guid? principalId = default(System.Guid?), string principalType = default(string), string resourceDisplayName = default(string), System.Guid? resourceId = default(System.Guid?))
            : base(additionalProperties, id, deletedDateTime)
        {
            AppRoleId = appRoleId;
            CreatedDateTime = createdDateTime;
            PrincipalDisplayName = principalDisplayName;
            PrincipalId = principalId;
            PrincipalType = principalType;
            ResourceDisplayName = resourceDisplayName;
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier (id) for the app role which is assigned
        /// to the principal. This app role must be exposed in the appRoles
        /// property on the resource application's service principal
        /// (resourceId). If the resource application has not declared any app
        /// roles, a default app role ID of
        /// 00000000-0000-0000-0000-000000000000 can be specified to signal
        /// that the principal is assigned to the resource app without any
        /// specific app roles. Required on create.
        /// </summary>
        [JsonProperty(PropertyName = "appRoleId")]
        public System.Guid? AppRoleId { get; set; }

        /// <summary>
        /// Gets or sets the time when the app role assignment was created.The
        /// Timestamp type represents date and time information using ISO 8601
        /// format and is always in UTC time. For example, midnight UTC on Jan
        /// 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user, group, or service
        /// principal that was granted the app role assignment. Read-only.
        /// Supports $filter (eq and startswith).
        /// </summary>
        [JsonProperty(PropertyName = "principalDisplayName")]
        public string PrincipalDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (id) for the user, group or
        /// service principal being granted the app role. Required on create.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the type of the assigned principal. This can either be
        /// User, Group or ServicePrincipal. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "principalType")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// Gets or sets the display name of the resource app's service
        /// principal to which the assignment is made.
        /// </summary>
        [JsonProperty(PropertyName = "resourceDisplayName")]
        public string ResourceDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier (id) for the resource service
        /// principal for which the assignment is made. Required on create.
        /// Supports $filter (eq only).
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public System.Guid? ResourceId { get; set; }

    }
}
