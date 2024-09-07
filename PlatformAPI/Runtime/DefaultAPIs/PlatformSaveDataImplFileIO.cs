using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Radish.Logging;

namespace Radish.PlatformAPI.DefaultAPIs
{
    /// <summary>
    /// A default implementation for reading and writing save data to the local OS user account's storage area.
    /// This will work at least on all desktop and mobile operating systems.
    /// Useful if shipping a non-steam build of something.
    /// </summary>
    [PublicAPI]
    public sealed class PlatformSaveDataImplFileIO : IPlatformSaveData
    {
        private static readonly ILogger Logger = LogManager.GetLoggerForType(typeof(PlatformSaveDataImplFileIO));
        
        private readonly string m_LocalPath;
        private readonly string m_UserPath;
        
        public PlatformSaveDataImplFileIO(string rootDataPath, string localDirName, string userDirName)
        {
            if (!Directory.Exists(rootDataPath))
                throw new DirectoryNotFoundException("Data root directory must exist before opening");

            m_LocalPath = Path.Combine(rootDataPath, localDirName);
            m_UserPath = Path.Combine(rootDataPath, userDirName);

            try
            {
                Directory.CreateDirectory(m_LocalPath);
                Directory.CreateDirectory(m_UserPath);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to set up data directories");
            }
        }
        
        public Stream OpenLocalDataStream(string name, IPlatformSaveData.OpenMode mode)
        {
            FileAccess fm = 0;
            if (mode.HasFlagT(IPlatformSaveData.OpenMode.Read))
                fm = FileAccess.Read;
            if (mode.HasFlagT(IPlatformSaveData.OpenMode.Write))
                fm = fm == FileAccess.Read ? FileAccess.ReadWrite : FileAccess.Write;

            if (fm == 0)
                throw new IOException($"{nameof(mode)} must be either Read, Write or both");

            try
            {
                var f = File.Open(Path.Combine(m_LocalPath, name), FileMode.OpenOrCreate, fm);
                return f;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to open '{0}'", name);
                return null;
            }
        }

        public bool DoesLocalDataExist(string name)
        {
            return File.Exists(Path.Combine(m_LocalPath, name));
        }

        public void DeleteLocalData(string name)
        {
            try
            {
                File.Delete(Path.Combine(m_LocalPath, name));
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to delete '{0}'", name);
            }
        }

        public IEnumerable<string> GetLocalDataNames()
        {
            try
            {
                return Directory.EnumerateFiles(m_LocalPath);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to get data names");
                return Enumerable.Empty<string>();
            }
        }

        public Stream OpenUserDataStream(string name, IPlatformSaveData.OpenMode mode)
        {
            FileAccess fm = 0;
            if (mode.HasFlagT(IPlatformSaveData.OpenMode.Read))
                fm = FileAccess.Read;
            if (mode.HasFlagT(IPlatformSaveData.OpenMode.Write))
                fm = fm == FileAccess.Read ? FileAccess.ReadWrite : FileAccess.Write;

            if (fm == 0)
                throw new IOException($"{nameof(mode)} must be either Read, Write or both");

            try
            {
                var f = File.Open(Path.Combine(m_UserPath, name), FileMode.OpenOrCreate, fm);
                return f;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to open '{0}'", name);
                return null;
            }
        }

        public bool DoesUserDataExist(string name)
        {
            return File.Exists(Path.Combine(m_UserPath, name));
        }

        public void DeleteUserData(string name)
        {
            try
            {
                File.Delete(Path.Combine(m_UserPath, name));
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to delete '{0}'", name);
            }
        }

        public IEnumerable<string> GetUserDataNames()
        {
            try
            {
                return Directory.EnumerateFiles(m_UserPath);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Failed to get data names");
                return Enumerable.Empty<string>();
            }
        }
    }
}