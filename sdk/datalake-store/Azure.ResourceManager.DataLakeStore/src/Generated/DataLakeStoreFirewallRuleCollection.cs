// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary>
    /// A class representing a collection of <see cref="DataLakeStoreFirewallRuleResource" /> and their operations.
    /// Each <see cref="DataLakeStoreFirewallRuleResource" /> in the collection will belong to the same instance of <see cref="DataLakeStoreAccountResource" />.
    /// To get a <see cref="DataLakeStoreFirewallRuleCollection" /> instance call the GetDataLakeStoreFirewallRules method from an instance of <see cref="DataLakeStoreAccountResource" />.
    /// </summary>
    public partial class DataLakeStoreFirewallRuleCollection : ArmCollection, IEnumerable<DataLakeStoreFirewallRuleResource>, IAsyncEnumerable<DataLakeStoreFirewallRuleResource>
    {
        private readonly ClientDiagnostics _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _dataLakeStoreFirewallRuleFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreFirewallRuleCollection"/> class for mocking. </summary>
        protected DataLakeStoreFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeStoreFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataLakeStoreFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", DataLakeStoreFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataLakeStoreFirewallRuleResource.ResourceType, out string dataLakeStoreFirewallRuleFirewallRulesApiVersion);
            _dataLakeStoreFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeStoreFirewallRuleFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataLakeStoreAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataLakeStoreAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified firewall rule. During update, the firewall rule with the specified name will be replaced with this new firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the firewall rule to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeStoreFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, DataLakeStoreFirewallRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreFirewallRuleResource>(Response.FromValue(new DataLakeStoreFirewallRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified firewall rule. During update, the firewall rule with the specified name will be replaced with this new firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the firewall rule to create or update. </param>
        /// <param name="content"> Parameters supplied to create or update the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataLakeStoreFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, DataLakeStoreFirewallRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataLakeStoreFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, content, cancellationToken);
                var operation = new DataLakeStoreArmOperation<DataLakeStoreFirewallRuleResource>(Response.FromValue(new DataLakeStoreFirewallRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<DataLakeStoreFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<DataLakeStoreFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _dataLakeStoreFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeStoreFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules
        /// Operation Id: FirewallRules_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataLakeStoreFirewallRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataLakeStoreFirewallRuleFirewallRulesRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataLakeStoreFirewallRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataLakeStoreFirewallRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataLakeStoreFirewallRuleFirewallRulesRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataLakeStoreFirewallRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data Lake Store account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules
        /// Operation Id: FirewallRules_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataLakeStoreFirewallRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataLakeStoreFirewallRuleFirewallRulesRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataLakeStoreFirewallRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataLakeStoreFirewallRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataLakeStoreFirewallRuleFirewallRulesRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataLakeStoreFirewallRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataLakeStoreFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}/firewallRules/{firewallRuleName}
        /// Operation Id: FirewallRules_Get
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _dataLakeStoreFirewallRuleFirewallRulesClientDiagnostics.CreateScope("DataLakeStoreFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataLakeStoreFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataLakeStoreFirewallRuleResource> IEnumerable<DataLakeStoreFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataLakeStoreFirewallRuleResource> IAsyncEnumerable<DataLakeStoreFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
