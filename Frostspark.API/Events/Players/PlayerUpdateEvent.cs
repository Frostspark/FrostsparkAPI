using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when the player has been updated by the server.
    /// </summary>
    public class PlayerUpdateEvent : PlayerEvent
    {
        public PlayerUpdateEvent(Player player, API.Server server) : base(player, server)
        {
        }
    }
}
