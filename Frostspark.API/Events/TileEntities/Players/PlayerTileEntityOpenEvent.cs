using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.TileEntities.Players
{
    public sealed class PlayerTileEntityOpenEvent : TileEntityEvent, IHasSource<Player>, ICancellable
    {
        public PlayerTileEntityOpenEvent(Player source, TileEntity target, API.Server server) : base(target, server)
        {
            Source = source;
        }

        public Player Source { get; }

        public bool Cancelled { get; set; }
    }
}
