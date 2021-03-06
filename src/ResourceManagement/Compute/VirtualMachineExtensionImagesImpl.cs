// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using ResourceManager.Fluent.Core;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The implementation for VirtualMachineExtensionImages.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbXB1dGUuaW1wbGVtZW50YXRpb24uVmlydHVhbE1hY2hpbmVFeHRlbnNpb25JbWFnZXNJbXBs
    internal partial class VirtualMachineExtensionImagesImpl :
        IVirtualMachineExtensionImages
    {
        private IVirtualMachinePublishers publishers;
        ///GENMHASH:5CB92C08673ABFA2D2A7D4213EB2D305:FA897FEBD514346FC3C576EAB52CCC9D
        internal VirtualMachineExtensionImagesImpl(IVirtualMachinePublishers publishers)
        {
            this.publishers = publishers;
        }

        ///GENMHASH:BA2FEDDF9D78BF55786D81F6C85E907C:CD5A589A9B297BE134944F6A531D30E8
        public IEnumerable<IVirtualMachineExtensionImage> ListByRegion(Region region)
        {
            return ListByRegion(region.Name);
        }

        ///GENMHASH:360BB74037893879A730ED7ED0A3938A:639E5895B91E59F5F02E157A874115D1
        public IEnumerable<IVirtualMachineExtensionImage> ListByRegion(string regionName)
        {
            return Publishers().ListByRegion(regionName)
                .SelectMany(publisher => publisher.ExtensionTypes
                                                  .List()
                                                  .SelectMany(type => type.Versions.List()))
                .Select(version => version.GetImage());
        }

        ///GENMHASH:2ED29FF482F2137640A1CA66925828A8:A1B832AC67AF06A35FD0BD5A16D29198
        public async Task<IPagedCollection<IVirtualMachineExtensionImage>>ListByRegionAsync(string region, CancellationToken cancellationToken)
        {
           return await PagedCollection<IVirtualMachineExtensionImage, IVirtualMachineExtensionImage>
                .LoadPage(async (cancellationToken1) =>
                {
                    var publisherCollection = await Publishers().ListByRegionAsync(region, cancellationToken);
                    var collectionOfextenionTypeCollection = await Task.WhenAll(publisherCollection
                        .Select(async (publisher) => await publisher.ExtensionTypes.ListAsync(true, cancellationToken)));
                    var collectionOfextensionImageVersionCollection = await Task.WhenAll(collectionOfextenionTypeCollection
                        .SelectMany(extensionTypeCollection => extensionTypeCollection.Select(async (extensionType) => await extensionType.Versions.ListAsync(true, cancellationToken))));
                    var extensionImageCollection = await Task.WhenAll(collectionOfextensionImageVersionCollection
                        .SelectMany(extensionImageVersionCollection => extensionImageVersionCollection.Select(async (extensionVersion) => await extensionVersion.GetImageAsync(cancellationToken))));
                    return extensionImageCollection;
                }, 
                image => image, 
                cancellationToken);
        }

        ///GENMHASH:271CC39CE723B6FD3D7CCA7471D4B201:039795D842B96323D94D260F3FF83299
        public async Task<IPagedCollection<IVirtualMachineExtensionImage>> ListByRegionAsync(Region region, CancellationToken cancellationToken)
        {
            return await ListByRegionAsync(region.Name, cancellationToken);
        }

        ///GENMHASH:0BEBF248F53E3703454D841A5CB0C8BD:F1262C25E062855DE7A22FF21A820919
        public IVirtualMachinePublishers Publishers()
        {
            return this.publishers;
        }
    }
}
