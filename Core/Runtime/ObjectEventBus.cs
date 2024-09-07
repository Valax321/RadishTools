//#define DEBUG_MESSAGES
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Radish.Logging;
using UnityEngine;
using UnityEngine.Profiling;
using ILogger = Radish.Logging.ILogger;

namespace Radish
{
    public sealed class ObjectEventBus : MonoBehaviour
    {
#if DEBUG_MESSAGES
        private static readonly ILogger Logger = LogManager.GetLoggerForType(typeof(ObjectEventBus));
#endif
        
        private readonly Dictionary<Type, object> m_MessageBusLookup = new();
        private readonly Dictionary<Type, string> m_ProfilerSampleNames = new();

        [PublicAPI]
        public void Publish<TMessage>(in TMessage message) where TMessage : struct, IEventBusMessage
        {
            var bus = GetOrCreateBus<TMessage>();

#if DEBUG_MESSAGES
            Logger.Info(this, "Message bus: dispatching message {0} ({1} subs)\nMessage: {2}", typeof(TMessage).FullName, bus.SubscriberCount, message);
#endif

            var samplerName =
                m_ProfilerSampleNames.GetOrAddValue(typeof(TMessage), () => $"Bus event {typeof(TMessage).FullName}");

            Profiler.BeginSample(samplerName, this);
            bus.Publish(message);
            Profiler.EndSample();
        }

        [PublicAPI]
        public void Subscribe<TMessage>(EventBus<TMessage>.OnMessage callback) where TMessage : struct, IEventBusMessage
        {
            var bus = GetOrCreateBus<TMessage>();
            bus.Subscribe(callback);
        }

        [PublicAPI]
        public void Unsubscribe<TMessage>(EventBus<TMessage>.OnMessage callback)
            where TMessage : struct, IEventBusMessage
        {
            var bus = GetOrCreateBus<TMessage>();
            bus.Unsubscribe(callback);
        }

        private EventBus<TMessage> GetOrCreateBus<TMessage>() where TMessage : struct, IEventBusMessage
        {
            if (!m_MessageBusLookup.ContainsKey(typeof(TMessage)))
            {
#if DEBUG_MESSAGES
                Logger.Info(this, "Initial access of bus for {0}, creating new bus instance", typeof(TMessage).FullName);
#endif

                m_MessageBusLookup.Add(typeof(TMessage), new EventBus<TMessage>());
            }

            return (EventBus<TMessage>)m_MessageBusLookup[typeof(TMessage)];
        }
    }
}