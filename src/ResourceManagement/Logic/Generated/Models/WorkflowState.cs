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
    /// Defines values for WorkflowState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowState
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Suspended")]
        Suspended
    }
    internal static class WorkflowStateEnumExtension
    {
        internal static string ToSerializedValue(this WorkflowState? value)
        {
            return value == null ? null : ((WorkflowState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WorkflowState value)
        {
            switch( value )
            {
                case WorkflowState.NotSpecified:
                    return "NotSpecified";
                case WorkflowState.Completed:
                    return "Completed";
                case WorkflowState.Enabled:
                    return "Enabled";
                case WorkflowState.Disabled:
                    return "Disabled";
                case WorkflowState.Deleted:
                    return "Deleted";
                case WorkflowState.Suspended:
                    return "Suspended";
            }
            return null;
        }

        internal static WorkflowState? ParseWorkflowState(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return WorkflowState.NotSpecified;
                case "Completed":
                    return WorkflowState.Completed;
                case "Enabled":
                    return WorkflowState.Enabled;
                case "Disabled":
                    return WorkflowState.Disabled;
                case "Deleted":
                    return WorkflowState.Deleted;
                case "Suspended":
                    return WorkflowState.Suspended;
            }
            return null;
        }
    }
}
