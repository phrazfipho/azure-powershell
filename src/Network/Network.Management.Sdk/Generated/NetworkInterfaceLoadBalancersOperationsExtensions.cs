// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NetworkInterfaceLoadBalancersOperations
    /// </summary>
    public static partial class NetworkInterfaceLoadBalancersOperationsExtensions
    {
        /// <summary>
        /// List all load balancers in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<LoadBalancer> List(this INetworkInterfaceLoadBalancersOperations operations, string resourceGroupName, string networkInterfaceName)
        {
                return ((INetworkInterfaceLoadBalancersOperations)operations).ListAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all load balancers in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<LoadBalancer>> ListAsync(this INetworkInterfaceLoadBalancersOperations operations, string resourceGroupName, string networkInterfaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List all load balancers in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<LoadBalancer> ListNext(this INetworkInterfaceLoadBalancersOperations operations, string nextPageLink)
        {
                return ((INetworkInterfaceLoadBalancersOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all load balancers in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<LoadBalancer>> ListNextAsync(this INetworkInterfaceLoadBalancersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
