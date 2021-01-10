using Frostspark.API.Events.Interfaces;

using System;

namespace Frostspark.API.Events
{
    public abstract class EventHandler<T> : EventHandler where T : Event
    {
        public override Type HandlerType => typeof(T);

        public sealed override void HandleEvent(Event e)
        {
            if (e is T t)
            {
                Handle(t);
            }
        }

        public abstract void Handle(T obj);
    }

    public abstract class EventHandler
    {
        public virtual bool AllowCanceled => true;

        public virtual int Priority => 0;

        public abstract Type HandlerType { get; }

        public abstract void HandleEvent(Event e);
    }
}
