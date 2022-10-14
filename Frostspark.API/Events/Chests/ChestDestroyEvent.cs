using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chests
{
    public class ChestDestroyEvent : ChestEvent, ICancellable
    {
        public ChestDestroyEvent(Chest chest, API.Server server) : base(chest, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
