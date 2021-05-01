using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public class ChestOpenEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public ChestOpenEvent(Player player, API.Entities.Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public Player Player { get; }

        /// <summary>
        /// Whether or not the opening action is canceled.
        /// </summary>
        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
