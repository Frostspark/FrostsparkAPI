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
    public sealed class PlayerMultiblockEditEvent : MultiblockEditEvent, IHasSource<Player>
    {
        public PlayerMultiblockEditEvent(Player source, (short frameX, short frameY)[,] new_frame_values, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(new_frame_values, area, tiles, world, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
