using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class BlockConvertBiomeEvent : SingleTileEvent, ICancellable
    {
        public BlockConvertBiomeEvent(int type, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Type = type;
        }

        public bool Cancelled { get; set; }

        public int Type { get; set; }
    }
}
