using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests
{
    public abstract class ChestEvent : Event, IHasTarget<API.Entities.Chest>
    {
        public ChestEvent(API.Entities.Chest chest, API.Server server) : base(server)
        {
            Chest = chest;
        }

        public API.Entities.Chest Chest { get; }

        API.Entities.Chest IHasTarget<API.Entities.Chest>.Target => Chest;
    }
}
