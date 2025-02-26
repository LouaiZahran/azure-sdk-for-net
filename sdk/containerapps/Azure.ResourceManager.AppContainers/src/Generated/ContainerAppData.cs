// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary> A class representing the ContainerApp data model. </summary>
    public partial class ContainerAppData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppData. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppData(AzureLocation location) : base(location)
        {
            OutboundIPAddresses = new ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of ContainerAppData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The complex type of the extended location. </param>
        /// <param name="identity"> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </param>
        /// <param name="provisioningState"> Provisioning state of the Container App. </param>
        /// <param name="managedEnvironmentId"> Deprecated. Resource ID of the Container App&apos;s environment. </param>
        /// <param name="environmentId"> Resource ID of environment. </param>
        /// <param name="workloadProfileType"> Workload profile type to pin for container app execution. </param>
        /// <param name="latestRevisionName"> Name of the latest revision of the Container App. </param>
        /// <param name="latestReadyRevisionName"> Name of the latest ready revision of the Container App. </param>
        /// <param name="latestRevisionFqdn"> Fully Qualified Domain Name of the latest revision of the Container App. </param>
        /// <param name="customDomainVerificationId"> Id used to verify domain name ownership. </param>
        /// <param name="configuration"> Non versioned Container App configuration properties. </param>
        /// <param name="template"> Container App versioned application definition. </param>
        /// <param name="outboundIPAddresses"> Outbound IP Addresses for container app. </param>
        /// <param name="eventStreamEndpoint"> The endpoint of the eventstream of the container app. </param>
        internal ContainerAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContainerAppExtendedLocation extendedLocation, ManagedServiceIdentity identity, ContainerAppProvisioningState? provisioningState, ResourceIdentifier managedEnvironmentId, ResourceIdentifier environmentId, string workloadProfileType, string latestRevisionName, string latestReadyRevisionName, string latestRevisionFqdn, string customDomainVerificationId, ContainerAppConfiguration configuration, ContainerAppTemplate template, IReadOnlyList<Uri> outboundIPAddresses, Uri eventStreamEndpoint) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Identity = identity;
            ProvisioningState = provisioningState;
            ManagedEnvironmentId = managedEnvironmentId;
            EnvironmentId = environmentId;
            WorkloadProfileType = workloadProfileType;
            LatestRevisionName = latestRevisionName;
            LatestReadyRevisionName = latestReadyRevisionName;
            LatestRevisionFqdn = latestRevisionFqdn;
            CustomDomainVerificationId = customDomainVerificationId;
            Configuration = configuration;
            Template = template;
            OutboundIPAddresses = outboundIPAddresses;
            EventStreamEndpoint = eventStreamEndpoint;
        }

        /// <summary> The complex type of the extended location. </summary>
        public ContainerAppExtendedLocation ExtendedLocation { get; set; }
        /// <summary> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the Container App. </summary>
        public ContainerAppProvisioningState? ProvisioningState { get; }
        /// <summary> Deprecated. Resource ID of the Container App&apos;s environment. </summary>
        public ResourceIdentifier ManagedEnvironmentId { get; set; }
        /// <summary> Resource ID of environment. </summary>
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary> Workload profile type to pin for container app execution. </summary>
        public string WorkloadProfileType { get; set; }
        /// <summary> Name of the latest revision of the Container App. </summary>
        public string LatestRevisionName { get; }
        /// <summary> Name of the latest ready revision of the Container App. </summary>
        public string LatestReadyRevisionName { get; }
        /// <summary> Fully Qualified Domain Name of the latest revision of the Container App. </summary>
        public string LatestRevisionFqdn { get; }
        /// <summary> Id used to verify domain name ownership. </summary>
        public string CustomDomainVerificationId { get; }
        /// <summary> Non versioned Container App configuration properties. </summary>
        public ContainerAppConfiguration Configuration { get; set; }
        /// <summary> Container App versioned application definition. </summary>
        public ContainerAppTemplate Template { get; set; }
        /// <summary> Outbound IP Addresses for container app. </summary>
        public IReadOnlyList<Uri> OutboundIPAddresses { get; }
        /// <summary> The endpoint of the eventstream of the container app. </summary>
        public Uri EventStreamEndpoint { get; }
    }
}
