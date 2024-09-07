using JetBrains.Annotations;
using Radish.PlatformAPI.DefaultAPIs;
using UnityEngine;

namespace Radish.PlatformAPI
{
    [PublicAPI]
    public sealed class StandalonePlatformSubsystem : IPlatformSubsystem
    {
        public string name => nameof(StandalonePlatformSubsystem);
        
        public OptionalAPI<IPlatformSaveData> saveData { get; }
            = OptionalAPI<IPlatformSaveData>.CreateForImplementation(
                new PlatformSaveDataImplFileIO(Application.persistentDataPath, 
                    "system", 
                    "user"
                    ));
        
        public OptionalAPI<IPlatformUserInfo> userInfo { get; }
            = OptionalAPI<IPlatformUserInfo>.CreateNotSupported("No online features");

        public bool Initialize() => true;

        public void Update()
        {
        }
    }
}