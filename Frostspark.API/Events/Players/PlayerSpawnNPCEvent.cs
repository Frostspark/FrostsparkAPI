using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public sealed class PlayerSpawnNPCEvent : PlayerEvent, IHasSource<Player>, ICancellable
    {
        public PlayerSpawnNPCEvent(int type, byte style, Player player, API.Server server) : base(player, server)
        {
            Type = type;
            Style = style;
            Source = player;
        }

        public int Type { get; set; }

        public byte Style { get; set; }

        public bool Cancelled { get; set; }

        public Player Source { get; }
    }
}
