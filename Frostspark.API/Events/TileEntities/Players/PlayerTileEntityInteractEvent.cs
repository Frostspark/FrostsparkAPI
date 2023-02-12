using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.TileEntities.Players
{
    public sealed class PlayerTileEntityInteractEvent : TileEntityEvent, IHasSource<Player>
    {
        public PlayerTileEntityInteractEvent(TileEntity target, API.Server server) : base(target, server)
        {
        }

        public Player Source { get; }
    }
}
