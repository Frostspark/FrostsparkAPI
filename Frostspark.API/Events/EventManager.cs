using Frostspark.API.Events.Interfaces;
using Frostspark.API.Plugins;

using System.Threading.Tasks;

namespace Frostspark.API.Events
{
    public abstract class EventManager
    {
        public abstract void RegisterHandler<TEvent>(Plugin plugin, SyncEventHandler<TEvent> handler) where TEvent : IEventHandlerCompatible;

        public abstract void RegisterAsyncHandler<TEvent>(Plugin plugin, AsyncEventHandler<TEvent> handler) where TEvent : IEventHandlerCompatible;

        public abstract void UnregisterHandler<TEvent>(Plugin plugin, SyncEventHandler<TEvent> handler) where TEvent : IEventHandlerCompatible;

        public abstract void UnregisterAsyncHandler<TEvent>(Plugin plugin, AsyncEventHandler<TEvent> handler) where TEvent : IEventHandlerCompatible;

        public abstract void FireEvent<TEvent>(TEvent obj) where TEvent : Event;

        public abstract Task FireEventAsync<TEvent>(TEvent obj) where TEvent : Event;
    }
}
