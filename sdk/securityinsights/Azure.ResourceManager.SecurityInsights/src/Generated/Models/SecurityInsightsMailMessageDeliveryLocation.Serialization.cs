// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal static partial class SecurityInsightsMailMessageDeliveryLocationExtensions
    {
        public static string ToSerialString(this SecurityInsightsMailMessageDeliveryLocation value) => value switch
        {
            SecurityInsightsMailMessageDeliveryLocation.Unknown => "Unknown",
            SecurityInsightsMailMessageDeliveryLocation.Inbox => "Inbox",
            SecurityInsightsMailMessageDeliveryLocation.JunkFolder => "JunkFolder",
            SecurityInsightsMailMessageDeliveryLocation.DeletedFolder => "DeletedFolder",
            SecurityInsightsMailMessageDeliveryLocation.Quarantine => "Quarantine",
            SecurityInsightsMailMessageDeliveryLocation.External => "External",
            SecurityInsightsMailMessageDeliveryLocation.Failed => "Failed",
            SecurityInsightsMailMessageDeliveryLocation.Dropped => "Dropped",
            SecurityInsightsMailMessageDeliveryLocation.Forwarded => "Forwarded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityInsightsMailMessageDeliveryLocation value.")
        };

        public static SecurityInsightsMailMessageDeliveryLocation ToSecurityInsightsMailMessageDeliveryLocation(this string value)
        {
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Unknown;
            if (string.Equals(value, "Inbox", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Inbox;
            if (string.Equals(value, "JunkFolder", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.JunkFolder;
            if (string.Equals(value, "DeletedFolder", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.DeletedFolder;
            if (string.Equals(value, "Quarantine", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Quarantine;
            if (string.Equals(value, "External", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.External;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Failed;
            if (string.Equals(value, "Dropped", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Dropped;
            if (string.Equals(value, "Forwarded", StringComparison.InvariantCultureIgnoreCase)) return SecurityInsightsMailMessageDeliveryLocation.Forwarded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityInsightsMailMessageDeliveryLocation value.");
        }
    }
}
