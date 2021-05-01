using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
