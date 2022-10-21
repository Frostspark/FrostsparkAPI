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
    public sealed class PlayerBlockEditEvent : BlockEditEvent, IHasSource<Player>
    {
        public PlayerBlockEditEvent(Player source, short framex, short framey, Tile tile, Worlds.World world, API.Server server) : base(framex, framey, tile, world, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
