using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.TileEntities
{
    public abstract class TileEntityEvent : Event, IHasTarget<TileEntity>
    {
        protected TileEntityEvent(TileEntity target, API.Server server) : base(server)
        {
            Target = target;
        }

        public TileEntity Target { get; }
    }
}
