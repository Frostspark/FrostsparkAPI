using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerMoveEvent : PlayerEvent, ICancellable
    {
        public PlayerMoveEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// Whether or not this move event is implicit (server simulation) or explicit (netcode induced)
        /// </summary>
        public bool Implicit { get; }

        /// <summary>
        /// The new movement status of the player.
        /// </summary>
        public Player.MovementData New { get; }

        public bool Cancelled { get; set; }
    }
}
