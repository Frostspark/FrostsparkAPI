using Frostspark.API.Events.Interfaces;
using Frostspark.API.Plugins;

using System;
using System.Collections.Generic;
using System.Text;

namespace Frostspark.API.Events.Plugins
{
    public class PluginEvent : Event, IHasTarget<Plugin>
    {
        public PluginEvent(Plugin plugin, API.Server server) : base(server)
        {
            Plugin = plugin;
        }

        /// <summary>
        /// The plugin involved with this event.
        /// </summary>
        public Plugin Plugin { get; }

        Plugin IHasTarget<Plugin>.Target => Plugin;
    }
}
