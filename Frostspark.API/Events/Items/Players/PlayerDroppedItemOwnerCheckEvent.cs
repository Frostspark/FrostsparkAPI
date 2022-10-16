using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items.Players
{
    public sealed class PlayerDroppedItemOwnerCheckEvent : DroppedItemEvent, ICancellable, IHasSource<Player>
    {
        public PlayerDroppedItemOwnerCheckEvent(Player player, DroppedItem item, API.Server server) : base(item, server)
        {
            Source = player;
        }

        public Player Source { get; }

        /// <summary>
        /// Cancelling this event will exclude this player from being the item owner and having the ability to pick it up.
        /// </summary>
        public bool Cancelled { get; set; }
    }
}
