// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update schedule operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduleCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateParameters
        /// class.
        /// </summary>
        public ScheduleCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the Schedule.</param>
        /// <param name="startTime">Gets or sets the start time of the
        /// schedule.</param>
        /// <param name="frequency">Possible values include: 'OneTime', 'Day',
        /// 'Hour', 'Week', 'Month'</param>
        /// <param name="description">Gets or sets the description of the
        /// schedule.</param>
        /// <param name="expiryTime">Gets or sets the end time of the
        /// schedule.</param>
        /// <param name="interval">Gets or sets the interval of the
        /// schedule.</param>
        /// <param name="timeZone">Gets or sets the time zone of the
        /// schedule.</param>
        /// <param name="advancedSchedule">Gets or sets the
        /// AdvancedSchedule.</param>
        public ScheduleCreateOrUpdateParameters(string name, System.DateTimeOffset startTime, string frequency, string description = default(string), System.DateTimeOffset? expiryTime = default(System.DateTimeOffset?), object interval = default(object), string timeZone = default(string), AdvancedSchedule advancedSchedule = default(AdvancedSchedule))
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            ExpiryTime = expiryTime;
            Interval = interval;
            Frequency = frequency;
            TimeZone = timeZone;
            AdvancedSchedule = advancedSchedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Schedule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the start time of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryTime")]
        public System.DateTimeOffset? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the interval of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interval")]
        public object Interval { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OneTime', 'Day', 'Hour',
        /// 'Week', 'Month'
        /// </summary>
        [JsonProperty(PropertyName = "properties.frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the time zone of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the AdvancedSchedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.advancedSchedule")]
        public AdvancedSchedule AdvancedSchedule { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Frequency == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Frequency");
            }
        }
    }
}
