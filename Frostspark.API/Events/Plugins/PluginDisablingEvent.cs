using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginDisablingEvent : PluginEvent
    {
        public PluginDisablingEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
