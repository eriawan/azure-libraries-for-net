// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    /// <summary>
    /// Defines values for VpnType.
    /// </summary>
    public class VpnType : ExpandableStringEnum<VpnType>
    {
        public static readonly VpnType PolicyBased = Parse("PolicyBased");
        public static readonly VpnType RouteBased = Parse("RouteBased");
    }
}