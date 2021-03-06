// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machines scale sets network configuration's DNS
    /// settings.
    /// </summary>
    public partial class VirtualMachineScaleSetNetworkConfigurationDnsSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfigurationDnsSettings class.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfigurationDnsSettings class.
        /// </summary>
        /// <param name="dnsServers">List of DNS servers IP addresses</param>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings(IList<string> dnsServers = default(IList<string>))
        {
            DnsServers = dnsServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of DNS servers IP addresses
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; set; }

    }
}
