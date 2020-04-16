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
        public delegate void EventHandler<T>(T eventobj);

        public abstract void RegisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler, int priority = 0, bool fire_cancelled = true);

        public abstract void UnregisterHandler<TEvent>(Plugin plugin, EventHandler<TEvent> handler);
    }
}
