using Frostspark.API.Logging;

using System;

namespace Frostspark.API.Plugins
{
    public abstract class PluginManager
    {
        public abstract PluginLoadResult LoadPlugin(string name);

        public abstract Plugin GetPlugin(string name);

        public abstract bool IsLoaded(string name);

        public abstract PluginUnloadResult UnloadPlugin(string name);

        protected static void SetEnabled(Plugin plugin)
        {
            plugin.Enable();
            plugin.Enabled = true;
        }

        protected static void SetDisabled(Plugin plugin)
        {
            plugin.Disable();
            plugin.Enabled = false;
        }

        protected static void SetLoaded(Plugin plugin)
        {
            plugin.Load();
            plugin.Loaded = true;
        }

        protected static void SetUnloaded(Plugin plugin)
        {
            plugin.Unload();
            plugin.Loaded = false;
        }

        protected static void SetLogger(Plugin plugin, Logger logger)
        {
            plugin.Log = logger;
        }
    }

    [Flags]
    public enum PluginLoadResult : byte
    {
        Success = 1,
        InvalidBinary = 2,
        AlreadyLoaded = 4,
        Exception = 8,
        NotFound = 16
    }

    [Flags]
    public enum PluginUnloadResult : byte
    {
        Found = 1,
        Exceptions = 2,
        Delayed = 4
    }
}
