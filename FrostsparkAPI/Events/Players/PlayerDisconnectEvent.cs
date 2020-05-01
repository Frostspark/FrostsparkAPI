using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player disconnects from the server.
    /// <para>This occurs after <see cref="PlayerKickEvent"/> if this is an involuntary disconnection.</para>
    /// </summary>
    public class PlayerDisconnectEvent : Event
    {
        public PlayerDisconnectEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The player that has disconnected.
        /// </summary>
        public Player Player { get; }
    }
}
