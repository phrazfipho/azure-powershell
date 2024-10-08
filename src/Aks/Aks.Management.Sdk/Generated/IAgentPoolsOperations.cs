// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AgentPoolsOperations operations.
    /// </summary>
    public partial interface IAgentPoolsOperations
    {
        /// <summary>
        /// Aborts the currently running operation on the agent pool. The Agent Pool
        /// will be moved to a Canceling state and eventually to a Canceled state when
        /// cancellation finishes. If the operation completes before cancellation can
        /// take place, a 409 error code is returned.
        /// </summary>
        /// <remarks>
        /// Aborts the currently running operation on the agent pool. The Agent Pool
        /// will be moved to a Canceling state and eventually to a Canceled state when
        /// cancellation finishes. If the operation completes before cancellation can
        /// take place, a 409 error code is returned.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AgentPoolsAbortLatestOperationHeaders>> AbortLatestOperationWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets a list of agent pools in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Gets a list of agent pools in the specified managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AgentPool>>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the specified managed cluster agent pool.
        /// </summary>
        /// <remarks>
        /// Gets the specified managed cluster agent pool.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPool>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates an agent pool in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Creates or updates an agent pool in the specified managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='parameters'>
        /// The agent pool to create or update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPool>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes an agent pool in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Deletes an agent pool in the specified managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AgentPoolsDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the upgrade profile for an agent pool.
        /// </summary>
        /// <remarks>
        /// Gets the upgrade profile for an agent pool.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPoolUpgradeProfile>> GetUpgradeProfileWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// See [supported Kubernetes
        /// versions](https://docs.microsoft.com/azure/aks/supported-kubernetes-versions)
        /// for more details about the version lifecycle.
        /// </summary>
        /// <remarks>
        /// See [supported Kubernetes
        /// versions](https://docs.microsoft.com/azure/aks/supported-kubernetes-versions)
        /// for more details about the version lifecycle.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPoolAvailableVersions>> GetAvailableAgentPoolVersionsWithHttpMessagesAsync(string resourceGroupName, string resourceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Upgrading the node image version of an agent pool applies the newest OS and
        /// runtime updates to the nodes. AKS provides one new image per week with the
        /// latest updates. For more details on node image versions, see:
        /// https://docs.microsoft.com/azure/aks/node-image-upgrade
        /// </summary>
        /// <remarks>
        /// Upgrading the node image version of an agent pool applies the newest OS and
        /// runtime updates to the nodes. AKS provides one new image per week with the
        /// latest updates. For more details on node image versions, see:
        /// https://docs.microsoft.com/azure/aks/node-image-upgrade
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPool,AgentPoolsUpgradeNodeImageVersionHeaders>> UpgradeNodeImageVersionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Aborts the currently running operation on the agent pool. The Agent Pool
        /// will be moved to a Canceling state and eventually to a Canceled state when
        /// cancellation finishes. If the operation completes before cancellation can
        /// take place, a 409 error code is returned.
        /// </summary>
        /// <remarks>
        /// Aborts the currently running operation on the agent pool. The Agent Pool
        /// will be moved to a Canceling state and eventually to a Canceled state when
        /// cancellation finishes. If the operation completes before cancellation can
        /// take place, a 409 error code is returned.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AgentPoolsAbortLatestOperationHeaders>> BeginAbortLatestOperationWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates an agent pool in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Creates or updates an agent pool in the specified managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='parameters'>
        /// The agent pool to create or update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPool>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, AgentPool parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes an agent pool in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Deletes an agent pool in the specified managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<AgentPoolsDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Upgrading the node image version of an agent pool applies the newest OS and
        /// runtime updates to the nodes. AKS provides one new image per week with the
        /// latest updates. For more details on node image versions, see:
        /// https://docs.microsoft.com/azure/aks/node-image-upgrade
        /// </summary>
        /// <remarks>
        /// Upgrading the node image version of an agent pool applies the newest OS and
        /// runtime updates to the nodes. AKS provides one new image per week with the
        /// latest updates. For more details on node image versions, see:
        /// https://docs.microsoft.com/azure/aks/node-image-upgrade
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the managed cluster resource.
        /// </param>
        /// <param name='agentPoolName'>
        /// The name of the agent pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AgentPool,AgentPoolsUpgradeNodeImageVersionHeaders>> BeginUpgradeNodeImageVersionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string agentPoolName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets a list of agent pools in the specified managed cluster.
        /// </summary>
        /// <remarks>
        /// Gets a list of agent pools in the specified managed cluster.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AgentPool>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}