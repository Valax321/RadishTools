using UnityEngine;
using VContainer.Unity;

namespace OrbHall.VContainer
{
    public abstract class GameStateBehaviour : LifetimeScope
    {
        public virtual bool persistent => false;

        private static GameObject s_ActiveStateObject;

        protected override void Awake()
        {
            base.Awake();
            
            if (Parent != null)
                Parent.Container.Inject(this);
        }

        protected virtual void Start()
        {
            if (s_ActiveStateObject && s_ActiveStateObject != gameObject)
            {
                var prevState = s_ActiveStateObject.GetComponent<GameStateBehaviour>();
                if (prevState.persistent && prevState.GetType() == GetType())
                {
                    Destroy(gameObject);
                    return;
                }
                
                Destroy(s_ActiveStateObject);
            }

            s_ActiveStateObject = gameObject;
            if (persistent)
                DontDestroyOnLoad(gameObject);
        }
        
        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (!persistent)
                s_ActiveStateObject = null;
        }
    }
}