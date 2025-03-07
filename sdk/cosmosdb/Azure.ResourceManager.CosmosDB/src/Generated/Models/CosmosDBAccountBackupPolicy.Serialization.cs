// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountBackupPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState");
                writer.WriteObjectValue(MigrationState);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBAccountBackupPolicy DeserializeCosmosDBAccountBackupPolicy(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Continuous": return ContinuousModeBackupPolicy.DeserializeContinuousModeBackupPolicy(element);
                    case "Periodic": return PeriodicModeBackupPolicy.DeserializePeriodicModeBackupPolicy(element);
                }
            }
            return UnknownBackupPolicy.DeserializeUnknownBackupPolicy(element);
        }
    }
}
