// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class ScanResults
    {
        internal static ScanResults DeserializeScanResults(JsonElement element)
        {
            Optional<IReadOnlyList<SqlVulnerabilityAssessmentScanResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlVulnerabilityAssessmentScanResult> array = new List<SqlVulnerabilityAssessmentScanResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlVulnerabilityAssessmentScanResult.DeserializeSqlVulnerabilityAssessmentScanResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ScanResults(Optional.ToList(value));
        }
    }
}
