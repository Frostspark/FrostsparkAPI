using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items.Players
{
    public sealed class PlayerDroppedItemUpdateEvent : DroppedItemUpdateEvent, IHasSource<Player>
    {
        public PlayerDroppedItemUpdateEvent(Player source, DroppedItem item, API.Server server) : base(item, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
