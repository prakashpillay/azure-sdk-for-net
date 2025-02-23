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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="GuestConfigurationVmAssignmentResource" /> and their operations.
    /// Each <see cref="GuestConfigurationVmAssignmentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="GuestConfigurationVmAssignmentCollection" /> instance call the GetGuestConfigurationVmAssignments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class GuestConfigurationVmAssignmentCollection : ArmCollection, IEnumerable<GuestConfigurationVmAssignmentResource>, IAsyncEnumerable<GuestConfigurationVmAssignmentResource>
    {
        private readonly ClientDiagnostics _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics;
        private readonly GuestConfigurationAssignmentsRestOperations _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient;
        private readonly string _vmName;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmAssignmentCollection"/> class for mocking. </summary>
        protected GuestConfigurationVmAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        internal GuestConfigurationVmAssignmentCollection(ArmClient client, ResourceIdentifier id, string vmName) : base(client, id)
        {
            _vmName = vmName;
            _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationVmAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GuestConfigurationVmAssignmentResource.ResourceType, out string guestConfigurationVmAssignmentGuestConfigurationAssignmentsApiVersion);
            _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient = new GuestConfigurationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationVmAssignmentGuestConfigurationAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an association between a VM and guest configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="guestConfigurationAssignmentName"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GuestConfigurationVmAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string guestConfigurationAssignmentName, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmAssignmentResource>(Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a VM and guest configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="guestConfigurationAssignmentName"> Name of the guest configuration assignment. </param>
        /// <param name="data"> Parameters supplied to the create or update guest configuration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GuestConfigurationVmAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string guestConfigurationAssignmentName, GuestConfigurationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, data, cancellationToken);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmAssignmentResource>(Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual async Task<Response<GuestConfigurationVmAssignmentResource>> GetAsync(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual Response<GuestConfigurationVmAssignmentResource> Get(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all guest configuration assignments for a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationVmAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationVmAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GuestConfigurationVmAssignmentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GuestConfigurationVmAssignmentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all guest configuration assignments for a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationVmAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationVmAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GuestConfigurationVmAssignmentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _vmName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GuestConfigurationVmAssignmentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var scope = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("GuestConfigurationVmAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vmName, guestConfigurationAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GuestConfigurationVmAssignmentResource> IEnumerable<GuestConfigurationVmAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GuestConfigurationVmAssignmentResource> IAsyncEnumerable<GuestConfigurationVmAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
