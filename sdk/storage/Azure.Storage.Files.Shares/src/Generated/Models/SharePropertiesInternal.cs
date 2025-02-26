// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Properties of a share. </summary>
    internal partial class SharePropertiesInternal
    {
        /// <summary> Initializes a new instance of SharePropertiesInternal. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="quota"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal SharePropertiesInternal(DateTimeOffset lastModified, string etag, int quota)
        {
            Argument.AssertNotNull(etag, nameof(etag));

            LastModified = lastModified;
            Etag = etag;
            Quota = quota;
        }

        /// <summary> Initializes a new instance of SharePropertiesInternal. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="quota"></param>
        /// <param name="provisionedIops"></param>
        /// <param name="provisionedIngressMBps"></param>
        /// <param name="provisionedEgressMBps"></param>
        /// <param name="provisionedBandwidthMiBps"></param>
        /// <param name="nextAllowedQuotaDowngradeTime"></param>
        /// <param name="deletedTime"></param>
        /// <param name="remainingRetentionDays"></param>
        /// <param name="accessTier"></param>
        /// <param name="accessTierChangeTime"></param>
        /// <param name="accessTierTransitionState"></param>
        /// <param name="leaseStatus"> The current lease status of the share. </param>
        /// <param name="leaseState"> Lease state of the share. </param>
        /// <param name="leaseDuration"> When a share is leased, specifies whether the lease is of infinite or fixed duration. </param>
        /// <param name="enabledProtocols"></param>
        /// <param name="rootSquash"></param>
        internal SharePropertiesInternal(DateTimeOffset lastModified, string etag, int quota, int? provisionedIops, int? provisionedIngressMBps, int? provisionedEgressMBps, int? provisionedBandwidthMiBps, DateTimeOffset? nextAllowedQuotaDowngradeTime, DateTimeOffset? deletedTime, int? remainingRetentionDays, string accessTier, DateTimeOffset? accessTierChangeTime, string accessTierTransitionState, ShareLeaseStatus? leaseStatus, ShareLeaseState? leaseState, ShareLeaseDuration? leaseDuration, string enabledProtocols, ShareRootSquash? rootSquash)
        {
            LastModified = lastModified;
            Etag = etag;
            Quota = quota;
            ProvisionedIops = provisionedIops;
            ProvisionedIngressMBps = provisionedIngressMBps;
            ProvisionedEgressMBps = provisionedEgressMBps;
            ProvisionedBandwidthMiBps = provisionedBandwidthMiBps;
            NextAllowedQuotaDowngradeTime = nextAllowedQuotaDowngradeTime;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTier = accessTier;
            AccessTierChangeTime = accessTierChangeTime;
            AccessTierTransitionState = accessTierTransitionState;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            EnabledProtocols = enabledProtocols;
            RootSquash = rootSquash;
        }

        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset LastModified { get; }
        /// <summary> Gets the etag. </summary>
        public string Etag { get; }
        /// <summary> Gets the quota. </summary>
        public int Quota { get; }
        /// <summary> Gets the provisioned iops. </summary>
        public int? ProvisionedIops { get; }
        /// <summary> Gets the provisioned ingress m bps. </summary>
        public int? ProvisionedIngressMBps { get; }
        /// <summary> Gets the provisioned egress m bps. </summary>
        public int? ProvisionedEgressMBps { get; }
        /// <summary> Gets the provisioned bandwidth mi bps. </summary>
        public int? ProvisionedBandwidthMiBps { get; }
        /// <summary> Gets the next allowed quota downgrade time. </summary>
        public DateTimeOffset? NextAllowedQuotaDowngradeTime { get; }
        /// <summary> Gets the deleted time. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> Gets the remaining retention days. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Gets the access tier. </summary>
        public string AccessTier { get; }
        /// <summary> Gets the access tier change time. </summary>
        public DateTimeOffset? AccessTierChangeTime { get; }
        /// <summary> Gets the access tier transition state. </summary>
        public string AccessTierTransitionState { get; }
        /// <summary> The current lease status of the share. </summary>
        public ShareLeaseStatus? LeaseStatus { get; }
        /// <summary> Lease state of the share. </summary>
        public ShareLeaseState? LeaseState { get; }
        /// <summary> When a share is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public ShareLeaseDuration? LeaseDuration { get; }
        /// <summary> Gets the enabled protocols. </summary>
        public string EnabledProtocols { get; }
        /// <summary> Gets the root squash. </summary>
        public ShareRootSquash? RootSquash { get; }
    }
}
