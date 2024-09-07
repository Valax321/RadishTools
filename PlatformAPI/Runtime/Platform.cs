using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Radish.Logging;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.PlayerLoop;
using ILogger = Radish.Logging.ILogger;

namespace Radish.PlatformAPI
{
    [PublicAPI]
    public static class Platform
    {
        private enum DefaultPlayerLoopCategory
        {
            TimeUpdate,
            Initialization,
            EarlyUpdate,
            FixedUpdate,
            PreUpdate,
            Update,
            PreLateUpdate,
            PostLateUpdate
        }
        
        private static readonly ILogger Logger = LogManager.GetLoggerForType(typeof(Platform));
        
        public static IPlatformSubsystem active { get; private set; }
        
        public static void InitializeWithSubsystemImpl(IPlatformSubsystem subsystemImpl)
        {
            if (subsystemImpl is null)
                throw new ArgumentNullException(nameof(subsystemImpl));

            var success = subsystemImpl.Initialize();
            if (!success)
            {
                Logger.Error("Platform subsystem '{0}' failed to initialize, quitting...", subsystemImpl.GetType().FullName);
                Application.Quit();
                return;
            }

            active = subsystemImpl;
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void InitializePlayerLoopHooks()
        {
            var loop = PlayerLoop.GetCurrentPlayerLoop();
            
            // Hook into the PreUpdate subsystem for dispatching online system callbacks
            ref var earlyUpdateSystem = ref loop.subSystemList[(int)DefaultPlayerLoopCategory.EarlyUpdate];
            var earlyUpdateSubsystems = new List<PlayerLoopSystem>(earlyUpdateSystem.subSystemList)
            {
                new()
                {
                    type = typeof(Platform),
                    updateDelegate = OnSubsystemUpdate
                }
            };
            earlyUpdateSystem.subSystemList = earlyUpdateSubsystems.ToArray();
            
            PlayerLoop.SetPlayerLoop(loop);
        }

        private static void OnSubsystemUpdate()
        {
            active?.Update();
        }
    }
}