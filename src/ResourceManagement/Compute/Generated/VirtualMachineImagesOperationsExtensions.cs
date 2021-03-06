// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineImagesOperations.
    /// </summary>
    public static partial class VirtualMachineImagesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='version'>
            /// A valid image SKU version.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineImageInner> GetAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, publisherName, offer, skus, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of all virtual machine image versions for the specified
            /// location, publisher, offer, and SKU.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='skus'>
            /// A valid image SKU.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResourceInner>> ListAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, ODataQuery<VirtualMachineImageResourceInner> odataQuery = default(ODataQuery<VirtualMachineImageResourceInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, publisherName, offer, skus, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image offers for the specified location and
            /// publisher.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResourceInner>> ListOffersAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOffersWithHttpMessagesAsync(location, publisherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers for the specified Azure
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResourceInner>> ListPublishersAsync(this IVirtualMachineImagesOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPublishersWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image SKUs for the specified location,
            /// publisher, and offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The name of a supported Azure region.
            /// </param>
            /// <param name='publisherName'>
            /// A valid image publisher.
            /// </param>
            /// <param name='offer'>
            /// A valid image publisher offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResourceInner>> ListSkusAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(location, publisherName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
