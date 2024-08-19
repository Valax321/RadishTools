using JetBrains.Annotations;
using UnityEngine;

namespace Radish
{
    public static class EventBusExtensions
    {
        [PublicAPI]
        public static ObjectEventBus GetEventBus(this GameObject go)
        {
            // Support hierarchy folders if available in project
            #if SISUS_AVAILABLE
            var root = go.GetRoot();
            #else
            var root = go.transform.root.gameObject;
            #endif
            
            if (!root)
                root = go;
            
            if (root.TryGetComponent(out ObjectEventBus bus))
                return bus;

            return root.AddComponent<ObjectEventBus>();
        }

        [PublicAPI]
        public static ObjectEventBus GetEventBus(this Component cmp) => GetEventBus(cmp.gameObject);
    }
}