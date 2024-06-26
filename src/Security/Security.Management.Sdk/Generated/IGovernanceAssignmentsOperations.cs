// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// GovernanceAssignmentsOperations operations.
    /// </summary>
    public partial interface IGovernanceAssignmentsOperations
    {
        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <remarks>
        /// Get governance assignments on all of your resources inside a scope
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GovernanceAssignment>>> ListWithHttpMessagesAsync(string scope, string assessmentName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// </summary>
        /// <remarks>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GovernanceAssignment>> GetWithHttpMessagesAsync(string scope, string assessmentName, string assignmentKey, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates a governance assignment on the given subscription.
        /// </summary>
        /// <remarks>
        /// Creates or updates a governance assignment on the given subscription.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        /// <param name='governanceAssignment'>
        /// Governance assignment over a subscription scope
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GovernanceAssignment>> CreateOrUpdateWithHttpMessagesAsync(string scope, string assessmentName, string assignmentKey, GovernanceAssignment governanceAssignment, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a GovernanceAssignment over a given scope
        /// </summary>
        /// <remarks>
        /// Delete a GovernanceAssignment over a given scope
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string scope, string assessmentName, string assignmentKey, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <remarks>
        /// Get governance assignments on all of your resources inside a scope
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
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GovernanceAssignment>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}