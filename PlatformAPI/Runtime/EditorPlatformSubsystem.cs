using System;
using System.IO;
using JetBrains.Annotations;
using Radish.PlatformAPI.DefaultAPIs;

#if UNITY_EDITOR

namespace Radish.PlatformAPI
{
    [PublicAPI]
    public class EditorPlatformSubsystem : IPlatformSubsystem
    {
        public string name => nameof(EditorPlatformSubsystem);
        
        public OptionalAPI<IPlatformSaveData> saveData { get; }
        
        public OptionalAPI<IPlatformUserInfo> userInfo { get; } 
            = OptionalAPI<IPlatformUserInfo>.CreateNotSupported("Editor has no online functionality");

        public EditorPlatformSubsystem()
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "SaveData"));
            saveData = OptionalAPI<IPlatformSaveData>.CreateForImplementation(
                new PlatformSaveDataImplFileIO(Path.Combine(Directory.GetCurrentDirectory(), "SaveData"), "system", Environment.UserName));
        }

        public bool Initialize() => true;

        public void Update()
        {
        }
    }
}
#endif