// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PoolLifetimeOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoolLifetimeOption
    {
        /// <summary>
        /// The pool exists for the lifetime of the job schedule. The Batch
        /// Service creates the pool when it creates the first job on the
        /// schedule. You may apply this option only to job schedules, not to
        /// jobs.
        /// </summary>
        [EnumMember(Value = "jobschedule")]
        JobSchedule,
        /// <summary>
        /// The pool exists for the lifetime of the job to which it is
        /// dedicated. The Batch service creates the pool when it creates the
        /// job. If the 'job' option is applied to a job schedule, the Batch
        /// service creates a new auto pool for every job created on the
        /// schedule.
        /// </summary>
        [EnumMember(Value = "job")]
        Job
    }
    internal static class PoolLifetimeOptionEnumExtension
    {
        internal static string ToSerializedValue(this PoolLifetimeOption? value)
        {
            return value == null ? null : ((PoolLifetimeOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PoolLifetimeOption value)
        {
            switch( value )
            {
                case PoolLifetimeOption.JobSchedule:
                    return "jobschedule";
                case PoolLifetimeOption.Job:
                    return "job";
            }
            return null;
        }

        internal static PoolLifetimeOption? ParsePoolLifetimeOption(this string value)
        {
            switch( value )
            {
                case "jobschedule":
                    return PoolLifetimeOption.JobSchedule;
                case "job":
                    return PoolLifetimeOption.Job;
            }
            return null;
        }
    }
}
