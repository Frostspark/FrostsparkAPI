using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class EventHandlerAttribute : Attribute
    {
        public readonly Type EventType;
        public readonly int Priority;
        public readonly bool FireCancelled;

        public EventHandlerAttribute(Type event_type, int priority = 0, bool fire_cancelled = true)
        {
            EventType = event_type;
            Priority = 0;
            FireCancelled = fire_cancelled;
        }
    }
}
