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
    public abstract class BlockCoatEvent : SingleTileEvent, ICancellable
    {
        protected BlockCoatEvent(CoatActionType action, CoatType coating, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Action = action;
            Coating = coating;
        }

        public CoatActionType Action { get; set; }

        public CoatType Coating { get; set; }

        public bool Cancelled { get; set; }
    }
}
