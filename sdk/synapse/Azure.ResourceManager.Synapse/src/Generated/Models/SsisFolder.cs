// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Ssis folder. </summary>
    public partial class SsisFolder : SsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SsisFolder. </summary>
        internal SsisFolder()
        {
            MetadataType = SsisObjectMetadataType.Folder;
        }

        /// <summary> Initializes a new instance of SsisFolder. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        internal SsisFolder(SsisObjectMetadataType metadataType, long? id, string name, string description) : base(metadataType, id, name, description)
        {
            MetadataType = metadataType;
        }
    }
}
