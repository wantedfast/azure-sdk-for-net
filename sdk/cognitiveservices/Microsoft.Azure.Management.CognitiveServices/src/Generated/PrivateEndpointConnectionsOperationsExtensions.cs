// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Gets the specified private endpoint connection associated with the
            /// Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, accountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified private endpoint connection associated with the
            /// Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection properties)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, privateEndpointConnectionName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of Cognitive Services account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Cognitive
            /// Services Account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
