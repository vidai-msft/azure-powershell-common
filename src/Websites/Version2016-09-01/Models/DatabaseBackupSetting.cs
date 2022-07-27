// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Database backup settings.
    /// </summary>
    public partial class DatabaseBackupSetting
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseBackupSetting class.
        /// </summary>
        public DatabaseBackupSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseBackupSetting class.
        /// </summary>
        /// <param name="databaseType">Database type (e.g. SqlAzure / MySql).
        /// Possible values include: 'SqlAzure', 'MySql', 'LocalMySql',
        /// 'PostgreSql'</param>
        /// <param name="name"></param>
        /// <param name="connectionStringName">Contains a connection string
        /// name that is linked to the SiteConfig.ConnectionStrings.
        /// This is used during restore with overwrite connection strings
        /// options.</param>
        /// <param name="connectionString">Contains a connection string to a
        /// database which is being backed up or restored. If the restore
        /// should happen to a new database, the database name inside is the
        /// new one.</param>
        public DatabaseBackupSetting(string databaseType, string name = default(string), string connectionStringName = default(string), string connectionString = default(string))
        {
            DatabaseType = databaseType;
            Name = name;
            ConnectionStringName = connectionStringName;
            ConnectionString = connectionString;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database type (e.g. SqlAzure / MySql). Possible values
        /// include: 'SqlAzure', 'MySql', 'LocalMySql', 'PostgreSql'
        /// </summary>
        [JsonProperty(PropertyName = "databaseType")]
        public string DatabaseType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets contains a connection string name that is linked to
        /// the SiteConfig.ConnectionStrings.
        /// This is used during restore with overwrite connection strings
        /// options.
        /// </summary>
        [JsonProperty(PropertyName = "connectionStringName")]
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// Gets or sets contains a connection string to a database which is
        /// being backed up or restored. If the restore should happen to a new
        /// database, the database name inside is the new one.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DatabaseType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseType");
            }
        }
    }
}
