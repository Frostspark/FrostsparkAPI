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

        protected static void EnablePlugin(Plugin plugin)
        {
            plugin.Enable();
            plugin.Enabled = true;
        }

        protected static void DisablePlugin(Plugin plugin)
        {
            plugin.Disable();
            plugin.Enabled = false;
        }
    }
}
