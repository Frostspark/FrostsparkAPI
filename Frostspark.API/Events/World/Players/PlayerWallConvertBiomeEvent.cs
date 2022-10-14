using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World.Players
{
    public sealed class PlayerWallConvertBiomeEvent : WallConvertBiomeEvent, IHasSource<Player>
    {
        public PlayerWallConvertBiomeEvent(Player player, int type, Tile tile, Worlds.World world, API.Server server) : base(type, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
