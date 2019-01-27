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
    /// Defines values for StartTaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StartTaskState
    {
        /// <summary>
        /// The start task is currently running.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>
        /// The start task has exited with exit code 0, or the start task has
        /// failed and the retry limit has reached, or the start task process
        /// did not run due to task preparation errors (such as resource file
        /// download failures).
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class StartTaskStateEnumExtension
    {
        internal static string ToSerializedValue(this StartTaskState? value)
        {
            return value == null ? null : ((StartTaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StartTaskState value)
        {
            switch( value )
            {
                case StartTaskState.Running:
                    return "running";
                case StartTaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static StartTaskState? ParseStartTaskState(this string value)
        {
            switch( value )
            {
                case "running":
                    return StartTaskState.Running;
                case "completed":
                    return StartTaskState.Completed;
            }
            return null;
        }
    }
}
