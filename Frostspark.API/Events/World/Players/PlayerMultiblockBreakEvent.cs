
using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World.Players
{
    public sealed class PlayerMultiblockBreakEvent : MultiblockBreakEvent, IHasSource<Player>
    {
        public PlayerMultiblockBreakEvent(Player player, bool fail, bool drops, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(fail, drops, area, tiles, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
