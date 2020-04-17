using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Plugins;

namespace Frostspark.API.Events
{
    public abstract class EventManager
    {
        public abstract void RegisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler) where TEvent : Event;

        public abstract void UnregisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler) where TEvent : Event;
    }
}
