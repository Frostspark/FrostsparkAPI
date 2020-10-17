using Frostspark.API.Plugins;

using System;
using System.Collections.Generic;
using System.Text;

namespace Frostspark.API.Events.Plugins
{
    public class PluginUnloadEvent : PluginEvent
    {
        public PluginUnloadEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
