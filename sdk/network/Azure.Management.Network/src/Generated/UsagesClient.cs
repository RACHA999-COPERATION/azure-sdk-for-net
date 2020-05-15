// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The Usages service client. </summary>
    public partial class UsagesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal UsagesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of UsagesClient for mocking. </summary>
        protected UsagesClient()
        {
        }
        /// <summary> Initializes a new instance of UsagesClient. </summary>
        internal UsagesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new UsagesRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List network usages for a subscription. </summary>
        /// <param name="location"> The location where resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Usage> ListAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsagesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(location, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Usage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsagesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, location, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List network usages for a subscription. </summary>
        /// <param name="location"> The location where resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Usage> List(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<Usage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsagesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(location, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Usage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsagesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, location, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}