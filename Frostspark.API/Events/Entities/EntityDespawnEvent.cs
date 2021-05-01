using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Entities
{
    public class EntityDespawnEvent : EntityEvent, ICancellable
    {
        public EntityDespawnEvent(Entity ent, EntityDespawnCause cause, API.Server server) : base(ent, server)
        {
            Cause = cause;
        }

        public bool Cancelled { get; set; }

        public EntityDespawnCause Cause { get; }

        public enum EntityDespawnCause
        {
            Natural,
            Death,
            API
        }
    }
}
