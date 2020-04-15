using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins
{
    public abstract class Plugin
    {
        /// <summary>
        /// This plugin's name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The plugin's load order.
        /// </summary>
        public virtual int LoadOrder => 0;

        /// <summary>
        /// Called when this plugin is enabled.
        /// </summary>
        public abstract void Enable();

        /// <summary>
        /// Called when this plugin is disabled.
        /// </summary>
        public abstract void Disable();

        /// <summary>
        /// Called when this plugin is loaded.
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Called when this plugin is unloaded.
        /// </summary>
        public abstract void Unload();
    }
}
