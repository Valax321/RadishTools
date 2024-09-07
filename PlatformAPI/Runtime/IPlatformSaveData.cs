using System;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;

namespace Radish.PlatformAPI
{
    [PublicAPI]
    public interface IPlatformSaveData
    {
        [Flags, PublicAPI]
        public enum OpenMode
        {
            Read = 1 << 0,
            Write = 1 << 1,
        }

        #region Local Data
        
        /// <summary>
        /// Opens a <see cref="Stream"/> for save data that is guaranteed not to be saved to the cloud.
        /// This will create the data if it does not exist.
        /// <remarks>Note: this will not necessarily be a file on disk!
        /// A file with the given name might not actually exist anywhere and should just be treated as a key into a table.</remarks>
        /// <seealso cref="OpenUserDataStream"/>
        /// </summary>
        /// <param name="name">The name (with extension) of the data to be saved.</param>
        /// <param name="mode">Flags controlling whether the data should be readable or writable.
        /// Both <see cref="OpenMode.Read"/> and <see cref="OpenMode.Write"/> can be ANDed to allow read and write at the same time.
        /// If neither mode is specified, an exception will be thrown.</param>
        /// <returns>A <see cref="Stream"/> representing the data.</returns>
        [CanBeNull]
        Stream OpenLocalDataStream(string name, OpenMode mode);

        /// <summary>
        /// Checks if local data with the given name exists.
        /// </summary>
        /// <param name="name">The name of the data to check for.</param>
        /// <returns>True if data was found, otherwise false.</returns>
        bool DoesLocalDataExist(string name);

        /// <summary>
        /// Deletes local data with the given name if it exists.
        /// </summary>
        /// <param name="name">The name of the data to delete.</param>
        void DeleteLocalData(string name);

        /// <summary>
        /// Gets the names of all local data.
        /// </summary>
        /// <returns>Enumerable local data names.</returns>
        IEnumerable<string> GetLocalDataNames();
        
        #endregion
        
        #region User Data

        /// <summary>
        /// Opens a <see cref="Stream"/> for save data that will be saved to the cloud if cloud save functionality is supported
        /// on the current platform.
        /// <remarks>Note: this will not necessarily be a file on disk!
        /// A file with the given name might not actually exist anywhere and should just be treated as a key into a table.</remarks>
        /// <seealso cref="OpenLocalDataStream"/>
        /// </summary>
        /// <param name="name">The name (with extension) of the data to be saved.</param>
        /// <param name="mode">Flags controlling whether the data should be readable or writable.
        /// Both <see cref="OpenMode.Read"/> and <see cref="OpenMode.Write"/> can be ANDed to allow read and write at the same time.
        /// If neither mode is specified, an exception will be thrown.</param>
        /// <returns>A <see cref="Stream"/> representing the data.</returns>
        [CanBeNull]
        Stream OpenUserDataStream(string name, OpenMode mode);

        /// <summary>
        /// Checks if user data with the given name exists.
        /// </summary>
        /// <param name="name">The name of the data to check for.</param>
        /// <returns>True if data was found, otherwise false.</returns>
        bool DoesUserDataExist(string name);
        
        /// <summary>
        /// Deletes user data with the given name if it exists.
        /// </summary>
        /// <param name="name">The name of the data to delete.</param>
        void DeleteUserData(string name);

        /// <summary>
        /// Gets the names of all user data.
        /// </summary>
        /// <returns>Enumerable user data names.</returns>
        IEnumerable<string> GetUserDataNames();

        #endregion
    }
}