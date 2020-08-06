using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Entities
{
    public abstract class EntityEvent : Event
    {
        public EntityEvent(API.Entities.Entity ent, API.Server server) : base(server)
        {
            Entity = ent;
        }

        public API.Entities.Entity Entity { get; }
    }
}
