// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Devices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Devices;
    using Microsoft.Azure.Management.Devices.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The operations monitoring properties for the IoT hub. The possible keys
    /// to the dictionary are Connections, DeviceTelemetry, C2DCommands,
    /// DeviceIdentityOperations, FileUploadOperations, Routes,
    /// D2CTwinOperations, C2DTwinOperations, TwinQueries, JobsOperations,
    /// DirectMethods.
    /// </summary>
    public partial class OperationsMonitoringProperties
    {
        /// <summary>
        /// Initializes a new instance of the OperationsMonitoringProperties
        /// class.
        /// </summary>
        public OperationsMonitoringProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationsMonitoringProperties
        /// class.
        /// </summary>
        public OperationsMonitoringProperties(IDictionary<string, string> events = default(IDictionary<string, string>))
        {
            Events = events;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IDictionary<string, string> Events { get; set; }

    }
}
