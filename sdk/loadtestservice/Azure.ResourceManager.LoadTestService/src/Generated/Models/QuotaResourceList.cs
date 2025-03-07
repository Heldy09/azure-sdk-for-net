// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LoadTestService;

namespace Azure.ResourceManager.LoadTestService.Models
{
    /// <summary> List of quota bucket objects. It contains a URL link to get the next set of results. </summary>
    internal partial class QuotaResourceList
    {
        /// <summary> Initializes a new instance of QuotaResourceList. </summary>
        internal QuotaResourceList()
        {
            Value = new ChangeTrackingList<QuotaResourceData>();
        }

        /// <summary> Initializes a new instance of QuotaResourceList. </summary>
        /// <param name="value"> List of quota bucket objects provided by the loadtestservice. </param>
        /// <param name="nextLink"> URL to get the next set of quota bucket objects results (if there are any). </param>
        internal QuotaResourceList(IReadOnlyList<QuotaResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of quota bucket objects provided by the loadtestservice. </summary>
        public IReadOnlyList<QuotaResourceData> Value { get; }
        /// <summary> URL to get the next set of quota bucket objects results (if there are any). </summary>
        public string NextLink { get; }
    }
}
