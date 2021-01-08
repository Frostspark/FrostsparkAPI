using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Entities
{
    public class EntitySpawnEvent : EntityEvent, ICancellable
    {
        public EntitySpawnEvent(Entity ent, API.Server server) : base(ent, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
