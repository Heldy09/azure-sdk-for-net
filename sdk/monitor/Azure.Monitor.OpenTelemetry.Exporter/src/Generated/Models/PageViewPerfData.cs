// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> An instance of PageViewPerf represents: a page view with no performance data, a page view with performance data, or just the performance data of an earlier page request. </summary>
    internal partial class PageViewPerfData : MonitorDomain
    {
        /// <summary> Initializes a new instance of PageViewPerfData. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        public PageViewPerfData(int version, string id, string name) : base(version)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(name, nameof(name));

            Id = id;
            Name = name;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </summary>
        public string Id { get; }
        /// <summary> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </summary>
        public string Name { get; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </summary>
        public string Duration { get; set; }
        /// <summary> Performance total in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public string PerfTotal { get; set; }
        /// <summary> Network connection time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public string NetworkConnect { get; set; }
        /// <summary> Sent request time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public string SentRequest { get; set; }
        /// <summary> Received response time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public string ReceivedResponse { get; set; }
        /// <summary> DOM processing time in TimeSpan &apos;G&apos; (general long) format: d:hh:mm:ss.fffffff. </summary>
        public string DomProcessing { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
