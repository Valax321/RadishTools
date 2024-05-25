using JetBrains.Annotations;

namespace Radish
{
    [PublicAPI]
    public class EventBus<T> where T : struct, IEventBusMessage
    {
        public delegate void OnMessage(in T message);
        
        private OnMessage m_CallbackDelegate;
        
        public int SubscriberCount { get; private set; }

        public void Publish(in T message)
        {
            m_CallbackDelegate?.Invoke(message);
        }

        public void Subscribe(OnMessage callback)
        {
            SubscriberCount++;
            m_CallbackDelegate += callback;
        }

        public void Unsubscribe(OnMessage callback)
        {
            SubscriberCount--;
            m_CallbackDelegate -= callback;
        }
    }
}