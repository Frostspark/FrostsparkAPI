using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public sealed class BlockShapeEvent : SingleTileEvent, IHasSource<Player>, ICancellable
    {
        public BlockShapeEvent(BlockShape shape, Player player, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Shape = shape;
            Source = player;
        }

        public bool Cancelled { get; set; }

        public Player Source { get; }

        public BlockShape Shape { get; set; }
    }
}
