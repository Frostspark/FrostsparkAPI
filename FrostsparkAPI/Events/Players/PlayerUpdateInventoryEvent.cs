using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired whenever a player updates their inventory.
    /// </summary>
    public class PlayerUpdateInventoryEvent : Event
    {
        public PlayerUpdateInventoryEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The player updating their inventory.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The slot being updated
        /// </summary>
        public int Slot { get; }
    }
}
