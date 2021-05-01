using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;
using Frostspark.API.Inventories;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired whenever a player updates their inventory.
    /// </summary>
    public class PlayerUpdateInventoryEvent : PlayerEvent
    {
        public PlayerUpdateInventoryEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The slot being updated
        /// </summary>
        public int Slot { get; set; }

        /// <summary>
        /// The item stack the player is setting to their inventory.
        /// </summary>
        public ItemStack Item { get; set; }
    }
}
