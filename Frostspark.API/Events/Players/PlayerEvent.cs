using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public abstract class PlayerEvent : Event, IHasTarget<Player>
    {
        protected PlayerEvent(Player player, API.Server server) : base(server)
        {
            Player = player;
        }

        public Player Player { get; }

        Player IHasTarget<Player>.Target => Player;
    }
}
