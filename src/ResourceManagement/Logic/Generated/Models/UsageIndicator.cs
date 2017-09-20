// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UsageIndicator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageIndicator
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Test")]
        Test,
        [EnumMember(Value = "Information")]
        Information,
        [EnumMember(Value = "Production")]
        Production
    }
    internal static class UsageIndicatorEnumExtension
    {
        internal static string ToSerializedValue(this UsageIndicator? value)
        {
            return value == null ? null : ((UsageIndicator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UsageIndicator value)
        {
            switch( value )
            {
                case UsageIndicator.NotSpecified:
                    return "NotSpecified";
                case UsageIndicator.Test:
                    return "Test";
                case UsageIndicator.Information:
                    return "Information";
                case UsageIndicator.Production:
                    return "Production";
            }
            return null;
        }

        internal static UsageIndicator? ParseUsageIndicator(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return UsageIndicator.NotSpecified;
                case "Test":
                    return UsageIndicator.Test;
                case "Information":
                    return UsageIndicator.Information;
                case "Production":
                    return UsageIndicator.Production;
            }
            return null;
        }
    }
}