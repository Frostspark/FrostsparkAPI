using Frostspark.API.Plugins;

namespace Frostspark.API.Events.Plugins
{
    public class PluginUnloadEvent : PluginEvent
    {
        public PluginUnloadEvent(Plugin plugin, API.Server server) : base(plugin, server)
        {
        }
    }
}
