using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginEnabledEvent : PluginEvent
    {
        public PluginEnabledEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
