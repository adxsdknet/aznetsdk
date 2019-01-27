// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Performance monitor API response.
    /// </summary>
    public partial class PerfMonResponse
    {
        /// <summary>
        /// Initializes a new instance of the PerfMonResponse class.
        /// </summary>
        public PerfMonResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerfMonResponse class.
        /// </summary>
        /// <param name="code">The response code.</param>
        /// <param name="message">The message.</param>
        /// <param name="data">The performance monitor counters.</param>
        public PerfMonResponse(string code = default(string), string message = default(string), PerfMonSet data = default(PerfMonSet))
        {
            Code = code;
            Message = message;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the response code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the performance monitor counters.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public PerfMonSet Data { get; set; }

    }
}
