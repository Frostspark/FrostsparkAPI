using Frostspark.API.Entities;

namespace Frostspark.API.Events.Entities
{
    public class EntitySpawnEvent : Event, ICancellable
    {
        public EntitySpawnEvent(API.Server server) : base(server)
        {
        }

        public Entity Entity { get; private set; }

        public bool Cancelled { get; set; }
    }
}
