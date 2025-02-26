// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan manual action details. </summary>
    public partial class RecoveryPlanManualActionDetails : RecoveryPlanActionDetails
    {
        /// <summary> Initializes a new instance of RecoveryPlanManualActionDetails. </summary>
        public RecoveryPlanManualActionDetails()
        {
            InstanceType = "ManualActionDetails";
        }

        /// <summary> Initializes a new instance of RecoveryPlanManualActionDetails. </summary>
        /// <param name="instanceType"> Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values). </param>
        /// <param name="description"> The manual action description. </param>
        internal RecoveryPlanManualActionDetails(string instanceType, string description) : base(instanceType)
        {
            Description = description;
            InstanceType = instanceType ?? "ManualActionDetails";
        }

        /// <summary> The manual action description. </summary>
        public string Description { get; set; }
    }
}
