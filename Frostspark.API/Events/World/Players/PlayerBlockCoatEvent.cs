using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World.Players
{
    public sealed class PlayerBlockCoatEvent : BlockCoatEvent, IHasSource<Player>
    {
        public PlayerBlockCoatEvent(Player source, CoatActionType action, CoatType coating, Tile tile, Worlds.World world, API.Server server) : base(action, coating, tile, world, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
