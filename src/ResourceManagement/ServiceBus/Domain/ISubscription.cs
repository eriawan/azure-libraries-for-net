// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ServiceBus.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.ServiceBus.Fluent.Models;
    using Microsoft.Azure.Management.ServiceBus.Fluent.Subscription.Update;
    using System;

    /// <summary>
    /// Type representing service bus topic subscription.
    /// </summary>
    public interface ISubscription  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IIndependentChildResource<Microsoft.Azure.Management.ServiceBus.Fluent.IServiceBusManager,Microsoft.Azure.Management.ServiceBus.Fluent.Models.SubscriptionInner>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.ServiceBus.Fluent.ISubscription>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IUpdatable<Subscription.Update.IUpdate>
    {
        /// <summary>
        /// Gets the maximum number of a message delivery before marking it as dead-lettered.
        /// </summary>
        int MaxDeliveryCountBeforeDeadLetteringMessage { get; }

        /// <summary>
        /// Gets the duration of peek-lock which is the amount of time that the message is locked for other receivers.
        /// </summary>
        long LockDurationInSeconds { get; }

        /// <summary>
        /// Gets last time there was a receive request to this subscription.
        /// </summary>
        System.DateTime AccessedAt { get; }

        /// <summary>
        /// Gets the current status of the subscription.
        /// </summary>
        Microsoft.Azure.Management.ServiceBus.Fluent.Models.EntityStatus Status { get; }

        /// <summary>
        /// Gets number of active messages in the subscription.
        /// </summary>
        long ActiveMessageCount { get; }

        /// <summary>
        /// Gets indicates whether server-side batched operations are enabled.
        /// </summary>
        bool IsBatchedOperationsEnabled { get; }

        /// <summary>
        /// Gets indicates whether the subscription supports sessions.
        /// </summary>
        bool IsSessionEnabled { get; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        System.DateTime UpdatedAt { get; }

        /// <summary>
        /// Gets number of messages transferred into dead letters.
        /// </summary>
        long TransferDeadLetterMessageCount { get; }

        /// <summary>
        /// Gets number of messages in the dead-letter subscription.
        /// </summary>
        long DeadLetterMessageCount { get; }

        /// <summary>
        /// Gets number of messages sent to the subscription that are yet to be released
        /// for consumption.
        /// </summary>
        long ScheduledMessageCount { get; }

        /// <summary>
        /// Gets the exact time the message was created.
        /// </summary>
        System.DateTime CreatedAt { get; }

        /// <summary>
        /// Gets the idle duration after which the subscription is automatically deleted.
        /// </summary>
        long DeleteOnIdleDurationInMinutes { get; }

        /// <summary>
        /// Gets the duration after which the message expires, starting from when the message is sent to subscription.
        /// </summary>
        System.TimeSpan DefaultMessageTtlDuration { get; }

        /// <summary>
        /// Gets number of messages transferred to another queue, topic, or subscription.
        /// </summary>
        long TransferMessageCount { get; }

        /// <summary>
        /// Gets indicates whether this subscription has dead letter support when a message expires.
        /// </summary>
        bool IsDeadLetteringEnabledForExpiredMessages { get; }

        /// <summary>
        /// Gets the number of messages in the subscription.
        /// </summary>
        long MessageCount { get; }

        /// <summary>
        /// Gets indicates whether subscription has dead letter support on filter evaluation exceptions.
        /// </summary>
        bool IsDeadLetteringEnabledForFilterEvaluationFailedMessages { get; }
    }
}