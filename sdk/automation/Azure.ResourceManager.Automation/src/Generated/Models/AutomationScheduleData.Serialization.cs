// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationScheduleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expiryTime");
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (Optional.IsDefined(ExpireInMinutes))
            {
                writer.WritePropertyName("expiryTimeOffsetMinutes");
                writer.WriteNumberValue(ExpireInMinutes.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(NextRunOn))
            {
                if (NextRunOn != null)
                {
                    writer.WritePropertyName("nextRun");
                    writer.WriteStringValue(NextRunOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("nextRun");
                }
            }
            if (Optional.IsDefined(NextRunInMinutes))
            {
                writer.WritePropertyName("nextRunOffsetMinutes");
                writer.WriteNumberValue(NextRunInMinutes.Value);
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Interval);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Interval.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency");
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone");
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(AdvancedSchedule))
            {
                writer.WritePropertyName("advancedSchedule");
                writer.WriteObjectValue(AdvancedSchedule);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime");
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutomationScheduleData DeserializeAutomationScheduleData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<double> startTimeOffsetMinutes = default;
            Optional<DateTimeOffset?> expiryTime = default;
            Optional<double> expiryTimeOffsetMinutes = default;
            Optional<bool> isEnabled = default;
            Optional<DateTimeOffset?> nextRun = default;
            Optional<double> nextRunOffsetMinutes = default;
            Optional<BinaryData> interval = default;
            Optional<AutomationScheduleFrequency> frequency = default;
            Optional<string> timeZone = default;
            Optional<AutomationAdvancedSchedule> advancedSchedule = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTimeOffsetMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTimeOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("expiryTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                expiryTime = null;
                                continue;
                            }
                            expiryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expiryTimeOffsetMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expiryTimeOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nextRun"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                nextRun = null;
                                continue;
                            }
                            nextRun = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nextRunOffsetMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nextRunOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("interval"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            interval = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("frequency"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frequency = new AutomationScheduleFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeZone"))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("advancedSchedule"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            advancedSchedule = AutomationAdvancedSchedule.DeserializeAutomationAdvancedSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
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
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationScheduleData(id, name, type, systemData.Value, Optional.ToNullable(startTime), Optional.ToNullable(startTimeOffsetMinutes), Optional.ToNullable(expiryTime), Optional.ToNullable(expiryTimeOffsetMinutes), Optional.ToNullable(isEnabled), Optional.ToNullable(nextRun), Optional.ToNullable(nextRunOffsetMinutes), interval.Value, Optional.ToNullable(frequency), timeZone.Value, advancedSchedule.Value, Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), description.Value);
        }
    }
}
