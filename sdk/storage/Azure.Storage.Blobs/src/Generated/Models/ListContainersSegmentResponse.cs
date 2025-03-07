// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An enumeration of containers. </summary>
    internal partial class ListContainersSegmentResponse
    {
        /// <summary> Initializes a new instance of ListContainersSegmentResponse. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="containerItems"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/> or <paramref name="containerItems"/> is null. </exception>
        internal ListContainersSegmentResponse(string serviceEndpoint, IEnumerable<ContainerItemInternal> containerItems)
        {
            Argument.AssertNotNull(serviceEndpoint, nameof(serviceEndpoint));
            Argument.AssertNotNull(containerItems, nameof(containerItems));

            ServiceEndpoint = serviceEndpoint;
            ContainerItems = containerItems.ToList();
        }

        /// <summary> Initializes a new instance of ListContainersSegmentResponse. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="containerItems"></param>
        /// <param name="nextMarker"></param>
        internal ListContainersSegmentResponse(string serviceEndpoint, string prefix, string marker, int? maxResults, IReadOnlyList<ContainerItemInternal> containerItems, string nextMarker)
        {
            ServiceEndpoint = serviceEndpoint;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            ContainerItems = containerItems;
            NextMarker = nextMarker;
        }

        /// <summary> Gets the service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Gets the prefix. </summary>
        public string Prefix { get; }
        /// <summary> Gets the marker. </summary>
        public string Marker { get; }
        /// <summary> Gets the max results. </summary>
        public int? MaxResults { get; }
        /// <summary> Gets the container items. </summary>
        public IReadOnlyList<ContainerItemInternal> ContainerItems { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
