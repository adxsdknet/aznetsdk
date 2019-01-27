// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output of the task that collects user tables for the given list of
    /// databases
    /// </summary>
    public partial class GetUserTablesSqlTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the GetUserTablesSqlTaskOutput class.
        /// </summary>
        public GetUserTablesSqlTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetUserTablesSqlTaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="databasesToTables">Mapping from database name to list
        /// of tables</param>
        /// <param name="validationErrors">Validation errors</param>
        public GetUserTablesSqlTaskOutput(string id = default(string), IDictionary<string, IList<DatabaseTable>> databasesToTables = default(IDictionary<string, IList<DatabaseTable>>), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            Id = id;
            DatabasesToTables = databasesToTables;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets mapping from database name to list of tables
        /// </summary>
        [JsonProperty(PropertyName = "databasesToTables")]
        public IDictionary<string, IList<DatabaseTable>> DatabasesToTables { get; private set; }

        /// <summary>
        /// Gets validation errors
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
