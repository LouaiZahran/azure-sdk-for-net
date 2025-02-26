// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Share
{
    // Data plane generated client.
    /// <summary> The AssetMappings service client. </summary>
    public partial class AssetMappingsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AssetMappingsClient for mocking. </summary>
        protected AssetMappingsClient()
        {
        }

        /// <summary> Initializes a new instance of AssetMappingsClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.purview.azure.com/share. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public AssetMappingsClient(string endpoint, TokenCredential credential) : this(endpoint, credential, new PurviewShareClientOptions())
        {
        }

        /// <summary> Initializes a new instance of AssetMappingsClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.purview.azure.com/share. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public AssetMappingsClient(string endpoint, TokenCredential credential, PurviewShareClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewShareClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get AssetMapping in a receivedShare. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='GetAssetMappingAsync(String,String,RequestContext)']/*" />
        public virtual async Task<Response> GetAssetMappingAsync(string receivedShareName, string assetMappingName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.GetAssetMapping");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAssetMappingRequest(receivedShareName, assetMappingName, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get AssetMapping in a receivedShare. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='GetAssetMapping(String,String,RequestContext)']/*" />
        public virtual Response GetAssetMapping(string receivedShareName, string assetMappingName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.GetAssetMapping");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAssetMappingRequest(receivedShareName, assetMappingName, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List AssetMappings in a received share. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="skipToken"> The continuation token to list the next page. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='GetAssetMappingsAsync(String,String,String,String,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetAssetMappingsAsync(string receivedShareName, string skipToken = null, string filter = null, string orderby = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));

            return GetAssetMappingsImplementationAsync("AssetMappingsClient.GetAssetMappings", receivedShareName, skipToken, filter, orderby, context);
        }

        private AsyncPageable<BinaryData> GetAssetMappingsImplementationAsync(string diagnosticsScopeName, string receivedShareName, string skipToken, string filter, string orderby, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAssetMappingsRequest(receivedShareName, skipToken, filter, orderby, context)
                        : CreateGetAssetMappingsNextPageRequest(nextLink, receivedShareName, skipToken, filter, orderby, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List AssetMappings in a received share. </summary>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="skipToken"> The continuation token to list the next page. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='GetAssetMappings(String,String,String,String,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetAssetMappings(string receivedShareName, string skipToken = null, string filter = null, string orderby = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));

            return GetAssetMappingsImplementation("AssetMappingsClient.GetAssetMappings", receivedShareName, skipToken, filter, orderby, context);
        }

        private Pageable<BinaryData> GetAssetMappingsImplementation(string diagnosticsScopeName, string receivedShareName, string skipToken, string filter, string orderby, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetAssetMappingsRequest(receivedShareName, skipToken, filter, orderby, context)
                        : CreateGetAssetMappingsNextPageRequest(nextLink, receivedShareName, skipToken, filter, orderby, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Maps a source asset in the sent share to a destination asset in the received share. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/>, <paramref name="assetMappingName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='CreateAsync(WaitUntil,String,String,RequestContent,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> CreateAsync(WaitUntil waitUntil, string receivedShareName, string assetMappingName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(receivedShareName, assetMappingName, content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "AssetMappingsClient.Create", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Maps a source asset in the sent share to a destination asset in the received share. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/>, <paramref name="assetMappingName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='Create(WaitUntil,String,String,RequestContent,RequestContext)']/*" />
        public virtual Operation<BinaryData> Create(WaitUntil waitUntil, string receivedShareName, string assetMappingName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(receivedShareName, assetMappingName, content, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "AssetMappingsClient.Create", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete AssetMapping in a receivedShare. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='DeleteAsync(WaitUntil,String,String,RequestContext)']/*" />
        public virtual async Task<Operation> DeleteAsync(WaitUntil waitUntil, string receivedShareName, string assetMappingName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(receivedShareName, assetMappingName, context);
                return await ProtocolOperationHelpers.ProcessMessageWithoutResponseValueAsync(_pipeline, message, ClientDiagnostics, "AssetMappingsClient.Delete", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete AssetMapping in a receivedShare. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="receivedShareName"> The name of the received share. </param>
        /// <param name="assetMappingName"> The name of the asset mapping. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="receivedShareName"/> or <paramref name="assetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/AssetMappingsClient.xml" path="doc/members/member[@name='Delete(WaitUntil,String,String,RequestContext)']/*" />
        public virtual Operation Delete(WaitUntil waitUntil, string receivedShareName, string assetMappingName, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(receivedShareName, nameof(receivedShareName));
            Argument.AssertNotNullOrEmpty(assetMappingName, nameof(assetMappingName));

            using var scope = ClientDiagnostics.CreateScope("AssetMappingsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(receivedShareName, assetMappingName, context);
                return ProtocolOperationHelpers.ProcessMessageWithoutResponseValue(_pipeline, message, ClientDiagnostics, "AssetMappingsClient.Delete", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAssetMappingsRequest(string receivedShareName, string skipToken, string filter, string orderby, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/receivedShares/", false);
            uri.AppendPath(receivedShareName, true);
            uri.AppendPath("/assetMappings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAssetMappingRequest(string receivedShareName, string assetMappingName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/receivedShares/", false);
            uri.AppendPath(receivedShareName, true);
            uri.AppendPath("/assetMappings/", false);
            uri.AppendPath(assetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateRequest(string receivedShareName, string assetMappingName, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/receivedShares/", false);
            uri.AppendPath(receivedShareName, true);
            uri.AppendPath("/assetMappings/", false);
            uri.AppendPath(assetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string receivedShareName, string assetMappingName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/receivedShares/", false);
            uri.AppendPath(receivedShareName, true);
            uri.AppendPath("/assetMappings/", false);
            uri.AppendPath(assetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAssetMappingsNextPageRequest(string nextLink, string receivedShareName, string skipToken, string filter, string orderby, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200202;
        private static ResponseClassifier ResponseClassifier200202 => _responseClassifier200202 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 202 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
