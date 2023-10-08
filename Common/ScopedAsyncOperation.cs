using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    public sealed class ScopedAsyncOperation : CustomYieldInstruction
    {
        public readonly struct ActivationToken
        {
            private readonly ScopedAsyncOperation m_Operation;

            internal ActivationToken(ScopedAsyncOperation operation)
            {
                m_Operation = operation;
            }

            [PublicAPI]
            public void Complete()
            {
                m_Operation.Complete();
            }
        }

        public override bool keepWaiting => !m_Completed;

        private bool m_Completed;

        [PublicAPI]
        public static ScopedAsyncOperation Create(out ActivationToken token)
        {
            var instance = new ScopedAsyncOperation();
            token = new ActivationToken(instance);
            return instance;
        }

        private void Complete()
        {
            m_Completed = true;
        }
    }
    
    public sealed class ScopedAsyncOperation<T> : CustomYieldInstruction
    {
        public readonly struct ActivationToken
        {
            private readonly ScopedAsyncOperation<T> m_Operation;

            internal ActivationToken(ScopedAsyncOperation<T> operation)
            {
                m_Operation = operation;
            }

            [PublicAPI]
            public void Complete(in T param)
            {
                m_Operation.Complete(param);
            }
        }

        public override bool keepWaiting => !m_Completed;
        
        [PublicAPI]
        public T result { get; private set; }

        private bool m_Completed;

        [PublicAPI]
        public static ScopedAsyncOperation<T> Create(out ActivationToken token)
        {
            var instance = new ScopedAsyncOperation<T>();
            token = new ActivationToken(instance);
            return instance;
        }

        private void Complete(in T param)
        {
            if (!m_Completed)
            {
                m_Completed = true;
                result = param;
            }
        }
    }
}