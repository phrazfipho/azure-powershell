// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// WorkspaceSettingsOperations operations.
    /// </summary>
    public partial interface IWorkspaceSettingsOperations
    {
        /// <summary>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
        /// </summary>
        /// <remarks>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
        /// </remarks>
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<WorkspaceSetting>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
        /// </summary>
        /// <remarks>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
        /// </remarks>
        /// <param name='workspaceSettingName'>
        /// Name of the security setting
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<WorkspaceSetting>> GetWithHttpMessagesAsync(string workspaceSettingName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// creating settings about where we should store your security data and logs
        /// </summary>
        /// <remarks>
        /// creating settings about where we should store your security data and logs
        /// </remarks>
        /// <param name='workspaceSettingName'>
        /// Name of the security setting
        /// </param>
        /// <param name='workspaceId'>
        /// The full Azure ID of the workspace to save the data in
        /// </param>
        /// <param name='scope'>
        /// All the VMs in this scope will send their security data to the mentioned workspace unless overridden by a setting with more specific scope
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<WorkspaceSetting>> CreateWithHttpMessagesAsync(string workspaceSettingName, string workspaceId = default(string), string scope = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Settings about where we should store your security data and logs
        /// </summary>
        /// <remarks>
        /// Settings about where we should store your security data and logs
        /// </remarks>
        /// <param name='workspaceSettingName'>
        /// Name of the security setting
        /// </param>
        /// <param name='workspaceId'>
        /// The full Azure ID of the workspace to save the data in
        /// </param>
        /// <param name='scope'>
        /// All the VMs in this scope will send their security data to the mentioned workspace unless overridden by a setting with more specific scope
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<WorkspaceSetting>> UpdateWithHttpMessagesAsync(string workspaceSettingName, string workspaceId = default(string), string scope = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the custom workspace settings for this subscription. new VMs will report to the default workspace
        /// </summary>
        /// <remarks>
        /// Deletes the custom workspace settings for this subscription. new VMs will report to the default workspace
        /// </remarks>
        /// <param name='workspaceSettingName'>
        /// Name of the security setting
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string workspaceSettingName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
        /// </summary>
        /// <remarks>
        /// Settings about where we should store your security data and logs. If the result is empty, it means that no custom-workspace configuration was set
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<WorkspaceSetting>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}