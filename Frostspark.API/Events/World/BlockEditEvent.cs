using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class BlockEditEvent : SingleTileEvent, ICancellable
    {
        protected BlockEditEvent(short framex, short framey, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            FrameX = framex;
            FrameY = framey;
        }

        public short FrameX { get; set; }

        public short FrameY { get; set; }

        public bool Cancelled { get; set; }
    }
}
