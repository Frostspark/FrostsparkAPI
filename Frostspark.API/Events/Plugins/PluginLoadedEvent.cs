using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginLoadedEvent : PluginEvent
    {
        public PluginLoadedEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
