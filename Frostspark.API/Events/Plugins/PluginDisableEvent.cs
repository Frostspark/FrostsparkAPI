using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginDisableEvent : PluginEvent
    {
        public PluginDisableEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
