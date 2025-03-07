// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBTableListResult
    {
        internal static CosmosDBTableListResult DeserializeCosmosDBTableListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CosmosDBTableData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBTableData> array = new List<CosmosDBTableData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBTableData.DeserializeCosmosDBTableData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBTableListResult(Optional.ToList(value));
        }
    }
}
