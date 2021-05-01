using Frostspark.API.Events.Interfaces;

using System;

namespace Frostspark.API.Events
{
    public abstract class SyncEventHandler<T> : SyncEventHandler where T : IEventHandlerCompatible
    {
        public sealed override void HandleEvent(IEventHandlerCompatible e)
        {
            if (e is T t)
            {
                Handle(t);
            }
        }

        public abstract void Handle(T obj);

        public override Type EventType => typeof(T);

    }

    public abstract class SyncEventHandler : EventHandler
    {
        public abstract void HandleEvent(IEventHandlerCompatible e);
    }
}
