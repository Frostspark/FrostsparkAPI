using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs.Players
{
    public sealed class PlayerSignDestroyEvent : SignDestroyEvent, IHasSource<Player>
    {
        public PlayerSignDestroyEvent(Player player, Sign sign, API.Server server) : base(sign, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
