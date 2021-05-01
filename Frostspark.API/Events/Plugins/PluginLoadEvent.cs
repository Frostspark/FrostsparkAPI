using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginLoadEvent : PluginEvent
    {
        public PluginLoadEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
