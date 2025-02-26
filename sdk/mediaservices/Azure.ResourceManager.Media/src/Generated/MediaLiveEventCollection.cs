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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaLiveEventResource" /> and their operations.
    /// Each <see cref="MediaLiveEventResource" /> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource" />.
    /// To get a <see cref="MediaLiveEventCollection" /> instance call the GetMediaLiveEvents method from an instance of <see cref="MediaServicesAccountResource" />.
    /// </summary>
    public partial class MediaLiveEventCollection : ArmCollection, IEnumerable<MediaLiveEventResource>, IAsyncEnumerable<MediaLiveEventResource>
    {
        private readonly ClientDiagnostics _mediaLiveEventLiveEventsClientDiagnostics;
        private readonly LiveEventsRestOperations _mediaLiveEventLiveEventsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaLiveEventCollection"/> class for mocking. </summary>
        protected MediaLiveEventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaLiveEventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaLiveEventCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaLiveEventLiveEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaLiveEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaLiveEventResource.ResourceType, out string mediaLiveEventLiveEventsApiVersion);
            _mediaLiveEventLiveEventsRestClient = new LiveEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaLiveEventLiveEventsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="data"> Live event properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaLiveEventResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string liveEventName, MediaLiveEventData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaLiveEventResource>(new MediaLiveEventOperationSource(Client), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, _mediaLiveEventLiveEventsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="data"> Live event properties needed for creation. </param>
        /// <param name="autoStart"> The flag indicates if the resource should be automatically started on creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaLiveEventResource> CreateOrUpdate(WaitUntil waitUntil, string liveEventName, MediaLiveEventData data, bool? autoStart = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart, cancellationToken);
                var operation = new MediaArmOperation<MediaLiveEventResource>(new MediaLiveEventOperationSource(Client), _mediaLiveEventLiveEventsClientDiagnostics, Pipeline, _mediaLiveEventLiveEventsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, data, autoStart).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of a live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Get
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual async Task<Response<MediaLiveEventResource>> GetAsync(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaLiveEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a live event.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Get
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual Response<MediaLiveEventResource> Get(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaLiveEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the live events in the account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents
        /// Operation Id: LiveEvents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaLiveEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaLiveEventResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MediaLiveEventResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mediaLiveEventLiveEventsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaLiveEventResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MediaLiveEventResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mediaLiveEventLiveEventsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaLiveEventResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
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
        /// Lists all the live events in the account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents
        /// Operation Id: LiveEvents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaLiveEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaLiveEventResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MediaLiveEventResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mediaLiveEventLiveEventsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaLiveEventResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MediaLiveEventResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mediaLiveEventLiveEventsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MediaLiveEventResource(Client, value)), response.Value.OdataNextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Get
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaLiveEventLiveEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}/liveEvents/{liveEventName}
        /// Operation Id: LiveEvents_Get
        /// </summary>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="liveEventName"/> is null. </exception>
        public virtual Response<bool> Exists(string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var scope = _mediaLiveEventLiveEventsClientDiagnostics.CreateScope("MediaLiveEventCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaLiveEventLiveEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, liveEventName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaLiveEventResource> IEnumerable<MediaLiveEventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaLiveEventResource> IAsyncEnumerable<MediaLiveEventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
