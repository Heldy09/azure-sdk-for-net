// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class SubRequest
    {
        internal static SubRequest DeserializeSubRequest(JsonElement element)
        {
            Optional<ResourceName> name = default;
            Optional<string> resourceType = default;
            Optional<string> unit = default;
            Optional<QuotaRequestState> provisioningState = default;
            Optional<string> message = default;
            Optional<string> subRequestId = default;
            Optional<LimitJsonObject> limit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = ResourceName.DeserializeResourceName(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new QuotaRequestState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subRequestId"))
                {
                    subRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = LimitJsonObject.DeserializeLimitJsonObject(property.Value);
                    continue;
                }
            }
            return new SubRequest(name.Value, resourceType.Value, unit.Value, Optional.ToNullable(provisioningState), message.Value, subRequestId.Value, limit.Value);
        }
    }
}
