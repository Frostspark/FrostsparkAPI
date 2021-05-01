using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginEnableEvent : PluginEvent
    {
        public PluginEnableEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
