using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginUnloadingEvent : PluginEvent
    {
        public PluginUnloadingEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
