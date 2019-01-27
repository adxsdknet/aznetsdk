// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UsageUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageUnit
    {
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "Seconds")]
        Seconds,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "CountsPerSecond")]
        CountsPerSecond,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond
    }
    internal static class UsageUnitEnumExtension
    {
        internal static string ToSerializedValue(this UsageUnit? value)
        {
            return value == null ? null : ((UsageUnit)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UsageUnit value)
        {
            switch( value )
            {
                case UsageUnit.Count:
                    return "Count";
                case UsageUnit.Bytes:
                    return "Bytes";
                case UsageUnit.Seconds:
                    return "Seconds";
                case UsageUnit.Percent:
                    return "Percent";
                case UsageUnit.CountsPerSecond:
                    return "CountsPerSecond";
                case UsageUnit.BytesPerSecond:
                    return "BytesPerSecond";
            }
            return null;
        }

        internal static UsageUnit? ParseUsageUnit(this string value)
        {
            switch( value )
            {
                case "Count":
                    return UsageUnit.Count;
                case "Bytes":
                    return UsageUnit.Bytes;
                case "Seconds":
                    return UsageUnit.Seconds;
                case "Percent":
                    return UsageUnit.Percent;
                case "CountsPerSecond":
                    return UsageUnit.CountsPerSecond;
                case "BytesPerSecond":
                    return UsageUnit.BytesPerSecond;
            }
            return null;
        }
    }
}
