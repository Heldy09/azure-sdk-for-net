// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBSyncTaskOutputDatabaseError
    {
        internal static MigrateSqlServerSqlDBSyncTaskOutputDatabaseError DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseError(JsonElement element)
        {
            Optional<string> errorMessage = default;
            Optional<IReadOnlyList<SyncMigrationDatabaseErrorEvent>> events = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncMigrationDatabaseErrorEvent> array = new List<SyncMigrationDatabaseErrorEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMigrationDatabaseErrorEvent.DeserializeSyncMigrationDatabaseErrorEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBSyncTaskOutputDatabaseError(id.Value, resultType, errorMessage.Value, Optional.ToList(events));
        }
    }
}
