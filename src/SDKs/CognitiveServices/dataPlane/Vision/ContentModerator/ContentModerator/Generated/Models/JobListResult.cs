// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of job ids.
    /// </summary>
    public partial class JobListResult
    {
        /// <summary>
        /// Initializes a new instance of the JobListResult class.
        /// </summary>
        public JobListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobListResult class.
        /// </summary>
        /// <param name="value">The job id.</param>
        public JobListResult(IList<string> value = default(IList<string>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job id.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public IList<string> Value { get; set; }

    }
}
