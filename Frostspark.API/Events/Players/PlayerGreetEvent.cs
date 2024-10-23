using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player is being greeted by the server.
    /// <br>Cancelling this will hide the vanilla MOTD.</br>
    /// </summary>
    public sealed class PlayerGreetEvent : PlayerEvent, ICancellable
    {
        public PlayerGreetEvent(Player player, API.Server server) : base(player, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
