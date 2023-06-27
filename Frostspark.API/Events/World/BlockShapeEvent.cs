using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Structures;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class BlockShapeEvent : SingleTileEvent, ICancellable
    {
        public BlockShapeEvent(BlockShape shape, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Shape = shape;
        }

        public bool Cancelled { get; set; }

        public BlockShape Shape { get; set; }
    }
}
