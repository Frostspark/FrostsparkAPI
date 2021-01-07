using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player is forcibly disconnected by the server.
    /// </summary>
    public class PlayerKickEvent : PlayerEvent
    {
        public PlayerKickEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The reason that will be displayed to the player.
        /// </summary>
        public string Reason { get; set; }
    }
}
