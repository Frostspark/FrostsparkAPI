using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items
{
    public abstract class DroppedItemRemoveEvent : DroppedItemEvent, ICancellable
    {
        public DroppedItemRemoveEvent(DroppedItem item, API.Server server) : base(item, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
