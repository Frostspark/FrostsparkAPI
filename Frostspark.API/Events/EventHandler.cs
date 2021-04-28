using Frostspark.API.Events.Interfaces;

using System;

namespace Frostspark.API.Events
{
    public abstract class EventHandler
    {
        public virtual bool AllowCanceled => true;

        public virtual int Priority => 0;

        public abstract Type EventType { get; }
    }
}
