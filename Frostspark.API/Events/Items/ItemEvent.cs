using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Items
{
    public abstract class ItemEvent : Event, IHasTarget<DroppedItem>
    {
        protected ItemEvent(DroppedItem item, API.Server server) : base(server)
        {
            Item = item;
        }

        public DroppedItem Item { get; }

        DroppedItem IHasTarget<DroppedItem>.Target => Item;
    }
}
