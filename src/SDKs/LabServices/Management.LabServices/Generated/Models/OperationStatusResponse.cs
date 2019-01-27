// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status Details of the long running operation for an environment
    /// </summary>
    public partial class OperationStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusResponse class.
        /// </summary>
        public OperationStatusResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusResponse class.
        /// </summary>
        /// <param name="status">status of the long running operation for an
        /// environment</param>
        public OperationStatusResponse(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets status of the long running operation for an environment
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
