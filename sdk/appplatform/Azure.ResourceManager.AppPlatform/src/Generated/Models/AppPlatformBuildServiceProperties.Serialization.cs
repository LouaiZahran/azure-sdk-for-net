// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KPackVersion))
            {
                writer.WritePropertyName("kPackVersion");
                writer.WriteStringValue(KPackVersion);
            }
            if (Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests");
                writer.WriteObjectValue(ResourceRequests);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformBuildServiceProperties DeserializeAppPlatformBuildServiceProperties(JsonElement element)
        {
            Optional<string> kPackVersion = default;
            Optional<AppPlatformBuildServiceProvisioningState> provisioningState = default;
            Optional<AppPlatformBuildServiceResourceRequirements> resourceRequests = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kPackVersion"))
                {
                    kPackVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new AppPlatformBuildServiceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceRequests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceRequests = AppPlatformBuildServiceResourceRequirements.DeserializeAppPlatformBuildServiceResourceRequirements(property.Value);
                    continue;
                }
            }
            return new AppPlatformBuildServiceProperties(kPackVersion.Value, Optional.ToNullable(provisioningState), resourceRequests.Value);
        }
    }
}
