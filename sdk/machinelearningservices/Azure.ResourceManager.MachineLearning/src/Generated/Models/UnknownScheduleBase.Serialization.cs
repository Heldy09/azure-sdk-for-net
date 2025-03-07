// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownScheduleBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime");
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Optional.IsDefined(ScheduleStatus))
            {
                writer.WritePropertyName("scheduleStatus");
                writer.WriteStringValue(ScheduleStatus.Value.ToString());
            }
            writer.WritePropertyName("scheduleType");
            writer.WriteStringValue(ScheduleType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime");
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(TimeZone))
            {
                if (TimeZone != null)
                {
                    writer.WritePropertyName("timeZone");
                    writer.WriteStringValue(TimeZone);
                }
                else
                {
                    writer.WriteNull("timeZone");
                }
            }
            writer.WriteEndObject();
        }

        internal static UnknownScheduleBase DeserializeUnknownScheduleBase(JsonElement element)
        {
            Optional<DateTimeOffset?> endTime = default;
            Optional<ScheduleStatus> scheduleStatus = default;
            ScheduleType scheduleType = "Unknown";
            Optional<DateTimeOffset?> startTime = default;
            Optional<string> timeZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduleStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduleStatus = new ScheduleStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleType"))
                {
                    scheduleType = new ScheduleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeZone"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeZone = null;
                        continue;
                    }
                    timeZone = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownScheduleBase(Optional.ToNullable(endTime), Optional.ToNullable(scheduleStatus), scheduleType, Optional.ToNullable(startTime), timeZone.Value);
        }
    }
}
