// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class FileShareData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShareQuota))
            {
                writer.WritePropertyName("shareQuota");
                writer.WriteNumberValue(ShareQuota.Value);
            }
            if (Optional.IsDefined(EnabledProtocol))
            {
                writer.WritePropertyName("enabledProtocols");
                writer.WriteStringValue(EnabledProtocol.Value.ToString());
            }
            if (Optional.IsDefined(RootSquash))
            {
                writer.WritePropertyName("rootSquash");
                writer.WriteStringValue(RootSquash.Value.ToString());
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SignedIdentifiers))
            {
                writer.WritePropertyName("signedIdentifiers");
                writer.WriteStartArray();
                foreach (var item in SignedIdentifiers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FileShareData DeserializeFileShareData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<int> shareQuota = default;
            Optional<FileShareEnabledProtocol> enabledProtocols = default;
            Optional<RootSquashType> rootSquash = default;
            Optional<string> version = default;
            Optional<bool> deleted = default;
            Optional<DateTimeOffset> deletedTime = default;
            Optional<int> remainingRetentionDays = default;
            Optional<FileShareAccessTier> accessTier = default;
            Optional<DateTimeOffset> accessTierChangeTime = default;
            Optional<string> accessTierStatus = default;
            Optional<long> shareUsageBytes = default;
            Optional<StorageLeaseStatus> leaseStatus = default;
            Optional<StorageLeaseState> leaseState = default;
            Optional<StorageLeaseDurationType> leaseDuration = default;
            Optional<IList<StorageSignedIdentifier>> signedIdentifiers = default;
            Optional<DateTimeOffset> snapshotTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shareQuota"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shareQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabledProtocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledProtocols = new FileShareEnabledProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rootSquash"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rootSquash = new RootSquashType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleted"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deletedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deletedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remainingRetentionDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remainingRetentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessTier = new FileShareAccessTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accessTierChangeTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessTierChangeTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessTierStatus"))
                        {
                            accessTierStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareUsageBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            shareUsageBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("leaseStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            leaseStatus = new StorageLeaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            leaseState = new StorageLeaseState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseDuration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            leaseDuration = new StorageLeaseDurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("signedIdentifiers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StorageSignedIdentifier> array = new List<StorageSignedIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageSignedIdentifier.DeserializeStorageSignedIdentifier(item));
                            }
                            signedIdentifiers = array;
                            continue;
                        }
                        if (property0.NameEquals("snapshotTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            snapshotTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FileShareData(id, name, type, systemData.Value, Optional.ToNullable(lastModifiedTime), Optional.ToDictionary(metadata), Optional.ToNullable(shareQuota), Optional.ToNullable(enabledProtocols), Optional.ToNullable(rootSquash), version.Value, Optional.ToNullable(deleted), Optional.ToNullable(deletedTime), Optional.ToNullable(remainingRetentionDays), Optional.ToNullable(accessTier), Optional.ToNullable(accessTierChangeTime), accessTierStatus.Value, Optional.ToNullable(shareUsageBytes), Optional.ToNullable(leaseStatus), Optional.ToNullable(leaseState), Optional.ToNullable(leaseDuration), Optional.ToList(signedIdentifiers), Optional.ToNullable(snapshotTime), Optional.ToNullable(etag));
        }
    }
}
