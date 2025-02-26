// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class Sample_ServiceBusQueueAuthorizationRuleResource
    {
        // QueueAuthorizationRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_QueueAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/examples/Queues/SBQueueAuthorizationRuleCreate.json
            // this example is just showing the usage of "QueueAuthorizationRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ServiceBusQueueAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusQueueAuthorizationRuleResource, please refer to the document of ServiceBusQueueAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-7982";
            string queueName = "sdk-Queues-2317";
            string authorizationRuleName = "sdk-AuthRules-5800";
            ResourceIdentifier serviceBusQueueAuthorizationRuleResourceId = ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName, authorizationRuleName);
            ServiceBusQueueAuthorizationRuleResource serviceBusQueueAuthorizationRule = client.GetServiceBusQueueAuthorizationRuleResource(serviceBusQueueAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusAuthorizationRuleData data = new ServiceBusAuthorizationRuleData()
            {
                Rights =
{
ServiceBusAccessRight.Listen,ServiceBusAccessRight.Send
},
            };
            ArmOperation<ServiceBusQueueAuthorizationRuleResource> lro = await serviceBusQueueAuthorizationRule.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusQueueAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // QueueAuthorizationRuleDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_QueueAuthorizationRuleDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/examples/Queues/SBQueueAuthorizationRuleDelete.json
            // this example is just showing the usage of "QueueAuthorizationRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ServiceBusQueueAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusQueueAuthorizationRuleResource, please refer to the document of ServiceBusQueueAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-7982";
            string queueName = "sdk-Queues-2317";
            string authorizationRuleName = "sdk-AuthRules-5800";
            ResourceIdentifier serviceBusQueueAuthorizationRuleResourceId = ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName, authorizationRuleName);
            ServiceBusQueueAuthorizationRuleResource serviceBusQueueAuthorizationRule = client.GetServiceBusQueueAuthorizationRuleResource(serviceBusQueueAuthorizationRuleResourceId);

            // invoke the operation
            await serviceBusQueueAuthorizationRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // QueueAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_QueueAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/examples/Queues/SBQueueAuthorizationRuleGet.json
            // this example is just showing the usage of "QueueAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ServiceBusQueueAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusQueueAuthorizationRuleResource, please refer to the document of ServiceBusQueueAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-7982";
            string queueName = "sdk-Queues-2317";
            string authorizationRuleName = "sdk-AuthRules-5800";
            ResourceIdentifier serviceBusQueueAuthorizationRuleResourceId = ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName, authorizationRuleName);
            ServiceBusQueueAuthorizationRuleResource serviceBusQueueAuthorizationRule = client.GetServiceBusQueueAuthorizationRuleResource(serviceBusQueueAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusQueueAuthorizationRuleResource result = await serviceBusQueueAuthorizationRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // QueueAuthorizationRuleListKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_QueueAuthorizationRuleListKey()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/examples/Queues/SBQueueAuthorizationRuleListKey.json
            // this example is just showing the usage of "QueueAuthorizationRules_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ServiceBusQueueAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusQueueAuthorizationRuleResource, please refer to the document of ServiceBusQueueAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-7982";
            string queueName = "sdk-Queues-2317";
            string authorizationRuleName = "sdk-AuthRules-5800";
            ResourceIdentifier serviceBusQueueAuthorizationRuleResourceId = ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName, authorizationRuleName);
            ServiceBusQueueAuthorizationRuleResource serviceBusQueueAuthorizationRule = client.GetServiceBusQueueAuthorizationRuleResource(serviceBusQueueAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusAccessKeys result = await serviceBusQueueAuthorizationRule.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // QueueAuthorizationRuleRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_QueueAuthorizationRuleRegenerateKey()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2021-11-01/examples/Queues/SBQueueAuthorizationRuleRegenerateKey.json
            // this example is just showing the usage of "QueueAuthorizationRules_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ServiceBusQueueAuthorizationRuleResource created on azure
            // for more information of creating ServiceBusQueueAuthorizationRuleResource, please refer to the document of ServiceBusQueueAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-namespace-7982";
            string queueName = "sdk-Queues-2317";
            string authorizationRuleName = "sdk-AuthRules-5800";
            ResourceIdentifier serviceBusQueueAuthorizationRuleResourceId = ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName, authorizationRuleName);
            ServiceBusQueueAuthorizationRuleResource serviceBusQueueAuthorizationRule = client.GetServiceBusQueueAuthorizationRuleResource(serviceBusQueueAuthorizationRuleResourceId);

            // invoke the operation
            ServiceBusRegenerateAccessKeyContent content = new ServiceBusRegenerateAccessKeyContent(ServiceBusAccessKeyType.PrimaryKey);
            ServiceBusAccessKeys result = await serviceBusQueueAuthorizationRule.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
