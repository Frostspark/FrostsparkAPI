using Frostspark.API.Plugins;

namespace Frostspark.API.Events
{
    public abstract class EventManager
    {
        public abstract void RegisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler) where TEvent : Event;

        public abstract void UnregisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler) where TEvent : Event;

        public abstract void FireEvent<TEvent>(TEvent obj) where TEvent : Event;
    }
}
