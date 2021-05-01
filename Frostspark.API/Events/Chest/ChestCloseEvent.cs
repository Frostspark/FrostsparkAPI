using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public class ChestCloseEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public ChestCloseEvent(Player player, API.Entities.Chest chest, API.Server server) : base(chest,server)
        {
            Player = player;
        }

        public Player Player { get; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
