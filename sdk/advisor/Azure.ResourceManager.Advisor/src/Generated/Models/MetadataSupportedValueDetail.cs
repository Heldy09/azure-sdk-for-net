// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The metadata supported value detail. </summary>
    public partial class MetadataSupportedValueDetail
    {
        /// <summary> Initializes a new instance of MetadataSupportedValueDetail. </summary>
        internal MetadataSupportedValueDetail()
        {
        }

        /// <summary> Initializes a new instance of MetadataSupportedValueDetail. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="displayName"> The display name. </param>
        internal MetadataSupportedValueDetail(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        /// <summary> The id. </summary>
        public string Id { get; }
        /// <summary> The display name. </summary>
        public string DisplayName { get; }
    }
}
