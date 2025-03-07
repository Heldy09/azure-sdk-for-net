// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class CertificateProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteBase64StringValue(Value, "D");
            }
            writer.WriteEndObject();
        }

        internal static CertificateProperties DeserializeCertificateProperties(JsonElement element)
        {
            Optional<CertificateProvisioningState> provisioningState = default;
            Optional<string> password = default;
            Optional<string> subjectName = default;
            Optional<IReadOnlyList<string>> subjectAlternativeNames = default;
            Optional<byte[]> value = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issueDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<string> thumbprint = default;
            Optional<bool> valid = default;
            Optional<string> publicKeyHash = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new CertificateProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectName"))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectAlternativeNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subjectAlternativeNames = array;
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("issuer"))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issueDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    issueDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicKeyHash"))
                {
                    publicKeyHash = property.Value.GetString();
                    continue;
                }
            }
            return new CertificateProperties(Optional.ToNullable(provisioningState), password.Value, subjectName.Value, Optional.ToList(subjectAlternativeNames), value.Value, issuer.Value, Optional.ToNullable(issueDate), Optional.ToNullable(expirationDate), thumbprint.Value, Optional.ToNullable(valid), publicKeyHash.Value);
        }
    }
}
