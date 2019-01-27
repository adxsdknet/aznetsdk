// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TasksOperations.
    /// </summary>
    public static partial class TasksOperationsExtensions
    {
            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            public static IPage<SecurityTask> List(this ITasksOperations operations, string filter = default(string))
            {
                return operations.ListAsync(filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityTask>> ListAsync(this ITasksOperations operations, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            public static IPage<SecurityTask> ListByHomeRegion(this ITasksOperations operations, string filter = default(string))
            {
                return operations.ListByHomeRegionAsync(filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityTask>> ListByHomeRegionAsync(this ITasksOperations operations, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            public static SecurityTask GetSubscriptionLevelTask(this ITasksOperations operations, string taskName)
            {
                return operations.GetSubscriptionLevelTaskAsync(taskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityTask> GetSubscriptionLevelTaskAsync(this ITasksOperations operations, string taskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionLevelTaskWithHttpMessagesAsync(taskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='taskUpdateActionType'>
            /// Type of the action to do on the task. Possible values include: 'Activate',
            /// 'Dismiss', 'Start', 'Resolve', 'Close'
            /// </param>
            public static void UpdateSubscriptionLevelTaskState(this ITasksOperations operations, string taskName, string taskUpdateActionType)
            {
                operations.UpdateSubscriptionLevelTaskStateAsync(taskName, taskUpdateActionType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='taskUpdateActionType'>
            /// Type of the action to do on the task. Possible values include: 'Activate',
            /// 'Dismiss', 'Start', 'Resolve', 'Close'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateSubscriptionLevelTaskStateAsync(this ITasksOperations operations, string taskName, string taskUpdateActionType, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateSubscriptionLevelTaskStateWithHttpMessagesAsync(taskName, taskUpdateActionType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            public static IPage<SecurityTask> ListByResourceGroup(this ITasksOperations operations, string resourceGroupName, string filter = default(string))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='filter'>
            /// OData filter. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityTask>> ListByResourceGroupAsync(this ITasksOperations operations, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            public static SecurityTask GetResourceGroupLevelTask(this ITasksOperations operations, string resourceGroupName, string taskName)
            {
                return operations.GetResourceGroupLevelTaskAsync(resourceGroupName, taskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityTask> GetResourceGroupLevelTaskAsync(this ITasksOperations operations, string resourceGroupName, string taskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceGroupLevelTaskWithHttpMessagesAsync(resourceGroupName, taskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='taskUpdateActionType'>
            /// Type of the action to do on the task. Possible values include: 'Activate',
            /// 'Dismiss', 'Start', 'Resolve', 'Close'
            /// </param>
            public static void UpdateResourceGroupLevelTaskState(this ITasksOperations operations, string resourceGroupName, string taskName, string taskUpdateActionType)
            {
                operations.UpdateResourceGroupLevelTaskStateAsync(resourceGroupName, taskName, taskUpdateActionType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='taskName'>
            /// Name of the task object, will be a GUID
            /// </param>
            /// <param name='taskUpdateActionType'>
            /// Type of the action to do on the task. Possible values include: 'Activate',
            /// 'Dismiss', 'Start', 'Resolve', 'Close'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateResourceGroupLevelTaskStateAsync(this ITasksOperations operations, string resourceGroupName, string taskName, string taskUpdateActionType, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateResourceGroupLevelTaskStateWithHttpMessagesAsync(resourceGroupName, taskName, taskUpdateActionType, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityTask> ListNext(this ITasksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
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
            public static async Task<IPage<SecurityTask>> ListNextAsync(this ITasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityTask> ListByHomeRegionNext(this ITasksOperations operations, string nextPageLink)
            {
                return operations.ListByHomeRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
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
            public static async Task<IPage<SecurityTask>> ListByHomeRegionNextAsync(this ITasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityTask> ListByResourceGroupNext(this ITasksOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Recommended tasks that will help improve the security of the subscription
            /// proactively
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
            public static async Task<IPage<SecurityTask>> ListByResourceGroupNextAsync(this ITasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
