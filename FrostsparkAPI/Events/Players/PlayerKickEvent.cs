using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Occurs when a <see cref="API.Entities.Player"/> is disconnected by the server.
    /// </summary>
    public class PlayerKickEvent : Event
    {
        public PlayerKickEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The player that is being disconnected.
        /// </summary>
        public Player Player { get; internal set; }

        /// <summary>
        /// The reason that will be displayed to the player.
        /// </summary>
        public string Reason { get; set; }
    }
}
