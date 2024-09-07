using JetBrains.Annotations;

namespace Radish.PlatformAPI
{
    /// <summary>
    /// Interface to a platform-specific set of APIs (Steam, Switch etc.)
    /// This is the wrapper for some general APIs and provides access to more specific API interfaces that may or may
    /// not be supported on some platforms. Be sure to check before using them!
    /// </summary>
    [PublicAPI]
    public interface IPlatformSubsystem
    {
        /// <summary>
        /// The display name for this API. For internal use only, not localized etc.
        /// </summary>
        string name { get; }
        
        /// <summary>
        /// API for reading and writing save data that may be cloud sync'd.
        /// </summary>
        public OptionalAPI<IPlatformSaveData> saveData { get; }
        
        /// <summary>
        /// API for getting information about the currently playing user.
        /// </summary>
        public OptionalAPI<IPlatformUserInfo> userInfo { get; }

        /// <summary>
        /// Initializes the subsystem.
        /// Can return null to notify the application that initialization failed.
        /// </summary>
        /// <returns>True if initialized successfully, otherwise false.</returns>
        bool Initialize();

        void Update();
    }
}