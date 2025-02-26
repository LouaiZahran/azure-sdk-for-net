// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview.Models;

namespace Azure.ResourceManager.Purview
{
    public partial class Sample_TenantResourceExtensions
    {
        // DefaultAccounts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDefaultAccount_DefaultAccountsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/DefaultAccounts_Get.json
            // this example is just showing the usage of "DefaultAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            Guid scopeTenantId = Guid.Parse("11733A4E-BA84-46FF-91D1-AFF1A3215A90");
            PurviewAccountScopeType scopeType = PurviewAccountScopeType.Tenant;
            string scope = "11733A4E-BA84-46FF-91D1-AFF1A3215A90";
            DefaultPurviewAccountPayload result = await tenantResource.GetDefaultAccountAsync(scopeTenantId, scopeType, scope: scope);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DefaultAccounts_Set
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SetDefaultAccount_DefaultAccountsSet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/DefaultAccounts_Set.json
            // this example is just showing the usage of "DefaultAccounts_Set" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            DefaultPurviewAccountPayload defaultAccountPayload = new DefaultPurviewAccountPayload()
            {
                AccountName = "myDefaultAccount",
                ResourceGroupName = "rg-1",
                Scope = "11733A4E-BA84-46FF-91D1-AFF1A3215A90",
                ScopeTenantId = Guid.Parse("11733A4E-BA84-46FF-91D1-AFF1A3215A90"),
                ScopeType = PurviewAccountScopeType.Tenant,
                SubscriptionId = "12345678-1234-1234-12345678aaa",
            };
            DefaultPurviewAccountPayload result = await tenantResource.SetDefaultAccountAsync(defaultAccountPayload);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DefaultAccounts_Remove
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RemoveDefaultAccount_DefaultAccountsRemove()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/stable/2021-07-01/examples/DefaultAccounts_Remove.json
            // this example is just showing the usage of "DefaultAccounts_Remove" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            Guid scopeTenantId = Guid.Parse("11733A4E-BA84-46FF-91D1-AFF1A3215A90");
            PurviewAccountScopeType scopeType = PurviewAccountScopeType.Tenant;
            string scope = "11733A4E-BA84-46FF-91D1-AFF1A3215A90";
            await tenantResource.RemoveDefaultAccountAsync(scopeTenantId, scopeType, scope: scope);

            Console.WriteLine($"Succeeded");
        }
    }
}
