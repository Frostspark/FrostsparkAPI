using Frostspark.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerCommandEvent : PlayerEvent, ICancellable
    {
        public PlayerCommandEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The command the player has issued, without the prefix.
        /// </summary>
        public string Command { get; set; }

        public bool Cancelled { get; set; }
    }
}
