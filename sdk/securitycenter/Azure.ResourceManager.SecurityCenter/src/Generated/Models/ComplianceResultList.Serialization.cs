// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class ComplianceResultList
    {
        internal static ComplianceResultList DeserializeComplianceResultList(JsonElement element)
        {
            IReadOnlyList<ComplianceResultData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ComplianceResultData> array = new List<ComplianceResultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplianceResultData.DeserializeComplianceResultData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ComplianceResultList(value, nextLink.Value);
        }
    }
}
