// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A Class representing an EventHubsNetworkRuleSet along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EventHubsNetworkRuleSetResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEventHubsNetworkRuleSetResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventHubsNamespaceResource" /> using the GetEventHubsNetworkRuleSet method.
    /// </summary>
    public partial class EventHubsNetworkRuleSetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventHubsNetworkRuleSetResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/networkRuleSets/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventHubsNetworkRuleSetNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _eventHubsNetworkRuleSetNamespacesRestClient;
        private readonly EventHubsNetworkRuleSetData _data;

        /// <summary> Initializes a new instance of the <see cref="EventHubsNetworkRuleSetResource"/> class for mocking. </summary>
        protected EventHubsNetworkRuleSetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EventHubsNetworkRuleSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventHubsNetworkRuleSetResource(ArmClient client, EventHubsNetworkRuleSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsNetworkRuleSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventHubsNetworkRuleSetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsNetworkRuleSetNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubsNetworkRuleSetNamespacesApiVersion);
            _eventHubsNetworkRuleSetNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsNetworkRuleSetNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/networkRuleSets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventHubsNetworkRuleSetData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_GetNetworkRuleSet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventHubsNetworkRuleSetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNetworkRuleSetNamespacesClientDiagnostics.CreateScope("EventHubsNetworkRuleSetResource.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsNetworkRuleSetNamespacesRestClient.GetNetworkRuleSetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNetworkRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_GetNetworkRuleSet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventHubsNetworkRuleSetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubsNetworkRuleSetNamespacesClientDiagnostics.CreateScope("EventHubsNetworkRuleSetResource.Get");
            scope.Start();
            try
            {
                var response = _eventHubsNetworkRuleSetNamespacesRestClient.GetNetworkRuleSet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsNetworkRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_CreateOrUpdateNetworkRuleSet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Namespace IpFilterRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsNetworkRuleSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, EventHubsNetworkRuleSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNetworkRuleSetNamespacesClientDiagnostics.CreateScope("EventHubsNetworkRuleSetResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsNetworkRuleSetNamespacesRestClient.CreateOrUpdateNetworkRuleSetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsNetworkRuleSetResource>(Response.FromValue(new EventHubsNetworkRuleSetResource(Client, response), response.GetRawResponse()));
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
        /// Create or update NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_CreateOrUpdateNetworkRuleSet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Namespace IpFilterRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsNetworkRuleSetResource> CreateOrUpdate(WaitUntil waitUntil, EventHubsNetworkRuleSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsNetworkRuleSetNamespacesClientDiagnostics.CreateScope("EventHubsNetworkRuleSetResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsNetworkRuleSetNamespacesRestClient.CreateOrUpdateNetworkRuleSet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsNetworkRuleSetResource>(Response.FromValue(new EventHubsNetworkRuleSetResource(Client, response), response.GetRawResponse()));
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
    }
}
