// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the disk to attach.
    /// </summary>
    public partial class AttachDiskProperties
    {
        /// <summary>
        /// Initializes a new instance of the AttachDiskProperties class.
        /// </summary>
        public AttachDiskProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttachDiskProperties class.
        /// </summary>
        /// <param name="leasedByLabVmId">The resource ID of the Lab virtual
        /// machine to which the disk is attached.</param>
        public AttachDiskProperties(string leasedByLabVmId = default(string))
        {
            LeasedByLabVmId = leasedByLabVmId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the Lab virtual machine to which
        /// the disk is attached.
        /// </summary>
        [JsonProperty(PropertyName = "leasedByLabVmId")]
        public string LeasedByLabVmId { get; set; }

    }
}
