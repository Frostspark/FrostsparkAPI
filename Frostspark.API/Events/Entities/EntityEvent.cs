using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Entities
{
    public abstract class EntityEvent : Event, IHasTarget<Entity>
    {
        public EntityEvent(Entity ent, API.Server server) : base(server)
        {
            Entity = ent;
        }

        public Entity Entity { get; }

        Entity IHasTarget<Entity>.Target => Entity;
    }
}
