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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing Abnormal Time Period detected.
    /// </summary>
    public partial class DetectorAbnormalTimePeriod
    {
        /// <summary>
        /// Initializes a new instance of the DetectorAbnormalTimePeriod class.
        /// </summary>
        public DetectorAbnormalTimePeriod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetectorAbnormalTimePeriod class.
        /// </summary>
        /// <param name="startTime">Start time of the corelated event</param>
        /// <param name="endTime">End time of the corelated event</param>
        /// <param name="message">Message describing the event</param>
        /// <param name="source">Represents the name of the Detector</param>
        /// <param name="priority">Represents the rank of the Detector</param>
        /// <param name="metaData">Downtime metadata</param>
        /// <param name="type">Represents the type of the Detector. Possible
        /// values include: 'ServiceIncident', 'AppDeployment', 'AppCrash',
        /// 'RuntimeIssueDetected', 'AseDeployment', 'UserIssue',
        /// 'PlatformIssue', 'Other'</param>
        /// <param name="solutions">List of proposed solutions</param>
        public DetectorAbnormalTimePeriod(System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string message = default(string), string source = default(string), double? priority = default(double?), IList<IList<NameValuePair>> metaData = default(IList<IList<NameValuePair>>), IssueType? type = default(IssueType?), IList<Solution> solutions = default(IList<Solution>))
        {
            StartTime = startTime;
            EndTime = endTime;
            Message = message;
            Source = source;
            Priority = priority;
            MetaData = metaData;
            Type = type;
            Solutions = solutions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time of the corelated event
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the corelated event
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets message describing the event
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets represents the name of the Detector
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets represents the rank of the Detector
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Gets or sets downtime metadata
        /// </summary>
        [JsonProperty(PropertyName = "metaData")]
        public IList<IList<NameValuePair>> MetaData { get; set; }

        /// <summary>
        /// Gets or sets represents the type of the Detector. Possible values
        /// include: 'ServiceIncident', 'AppDeployment', 'AppCrash',
        /// 'RuntimeIssueDetected', 'AseDeployment', 'UserIssue',
        /// 'PlatformIssue', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IssueType? Type { get; set; }

        /// <summary>
        /// Gets or sets list of proposed solutions
        /// </summary>
        [JsonProperty(PropertyName = "solutions")]
        public IList<Solution> Solutions { get; set; }

    }
}
