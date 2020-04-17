using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins
{
    public abstract class PluginManager
    {
        public abstract void LoadPlugin(string name);

        public abstract Plugin GetPlugin(string name);

        public abstract void UnloadPlugin(string name);

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
    }
}
