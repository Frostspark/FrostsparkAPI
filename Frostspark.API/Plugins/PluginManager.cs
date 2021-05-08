using Frostspark.API.Logging;

using System;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins
{
    public abstract class PluginManager
    {
        public abstract Task<PluginLoadResult> LoadPlugin(string name);

        public abstract Plugin GetPlugin(string name);

        public abstract bool IsLoaded(string name);

        public abstract Task<PluginUnloadResult> UnloadPlugin(string name);

        protected static async Task SetEnabled(Plugin plugin)
        {
            await plugin.Enable().ConfigureAwait(false);
            plugin.Enabled = true;
        }

        protected static async Task SetDisabled(Plugin plugin)
        {
            await plugin.Disable().ConfigureAwait(false);
            plugin.Enabled = false;
        }

        protected static async Task SetLoaded(Plugin plugin)
        {
            await plugin.Load().ConfigureAwait(false);
            plugin.Loaded = true;
        }

        protected static async Task SetUnloaded(Plugin plugin)
        {
            await plugin.Unload().ConfigureAwait(false);
            plugin.Loaded = false;
        }

        protected static void SetLogger(Plugin plugin, Logger logger)
        {
            plugin.Log = logger;
        }

        protected static void SetDataFolder(Plugin plugin, string path)
        {
            plugin.DataFolder = path;
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
