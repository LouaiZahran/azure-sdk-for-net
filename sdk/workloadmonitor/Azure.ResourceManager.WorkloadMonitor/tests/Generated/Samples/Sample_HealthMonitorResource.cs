// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.WorkloadMonitor
{
    public partial class Sample_HealthMonitorResource
    {
        // Get monitor with default values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMonitorWithDefaultValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/Monitor_GetDefault.json
            // this example is just showing the usage of "HealthMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A|free-space";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // invoke the operation
            HealthMonitorResource result = await healthMonitor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get monitor with expanded values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetMonitorWithExpandedValues()
        {
            // Generated from example definition: specification/workloadmonitor/resource-manager/Microsoft.WorkloadMonitor/preview/2020-01-13-preview/examples/Monitor_GetExpanded.json
            // this example is just showing the usage of "HealthMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthMonitorResource created on azure
            // for more information of creating HealthMonitorResource, please refer to the document of HealthMonitorResource
            string subscriptionId = "bc27da3b-3ba2-4e00-a6ec-1fde64aa1e21";
            string resourceGroupName = "tugamidiAlerts";
            string providerName = "Microsoft.Compute";
            string resourceCollectionName = "virtualMachines";
            string resourceName = "linuxEUS";
            string monitorId = "logical-disks|C@3A|free-space";
            ResourceIdentifier healthMonitorResourceId = HealthMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, providerName, resourceCollectionName, resourceName, monitorId);
            HealthMonitorResource healthMonitor = client.GetHealthMonitorResource(healthMonitorResourceId);

            // invoke the operation
            string expand = "evidence";
            HealthMonitorResource result = await healthMonitor.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
