using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

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
