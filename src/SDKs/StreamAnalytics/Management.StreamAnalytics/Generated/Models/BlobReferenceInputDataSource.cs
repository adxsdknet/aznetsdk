// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a blob input data source that contains reference data.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Storage/Blob")]
    [Rest.Serialization.JsonTransformation]
    public partial class BlobReferenceInputDataSource : ReferenceInputDataSource
    {
        /// <summary>
        /// Initializes a new instance of the BlobReferenceInputDataSource
        /// class.
        /// </summary>
        public BlobReferenceInputDataSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobReferenceInputDataSource
        /// class.
        /// </summary>
        /// <param name="storageAccounts">A list of one or more Azure Storage
        /// accounts. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="container">The name of a container within the
        /// associated Storage account. This container contains either the
        /// blob(s) to be read from or written to. Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="pathPattern">The blob path pattern. Not a regular
        /// expression. It represents a pattern against which blob names will
        /// be matched to determine whether or not they should be included as
        /// input or output to the job. See
        /// https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input
        /// or
        /// https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output
        /// for a more detailed explanation and example.</param>
        /// <param name="dateFormat">The date format. Wherever {date} appears
        /// in pathPattern, the value of this property is used as the date
        /// format instead.</param>
        /// <param name="timeFormat">The time format. Wherever {time} appears
        /// in pathPattern, the value of this property is used as the time
        /// format instead.</param>
        public BlobReferenceInputDataSource(IList<StorageAccount> storageAccounts = default(IList<StorageAccount>), string container = default(string), string pathPattern = default(string), string dateFormat = default(string), string timeFormat = default(string))
        {
            StorageAccounts = storageAccounts;
            Container = container;
            PathPattern = pathPattern;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of one or more Azure Storage accounts. Required
        /// on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccount> StorageAccounts { get; set; }

        /// <summary>
        /// Gets or sets the name of a container within the associated Storage
        /// account. This container contains either the blob(s) to be read from
        /// or written to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets the blob path pattern. Not a regular expression. It
        /// represents a pattern against which blob names will be matched to
        /// determine whether or not they should be included as input or output
        /// to the job. See
        /// https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input
        /// or
        /// https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output
        /// for a more detailed explanation and example.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pathPattern")]
        public string PathPattern { get; set; }

        /// <summary>
        /// Gets or sets the date format. Wherever {date} appears in
        /// pathPattern, the value of this property is used as the date format
        /// instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dateFormat")]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or sets the time format. Wherever {time} appears in
        /// pathPattern, the value of this property is used as the time format
        /// instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeFormat")]
        public string TimeFormat { get; set; }

    }
}
