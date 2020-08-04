using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items
{
    public abstract class ItemEvent : Event
    {
        protected ItemEvent(API.Entities.DroppedItem item, API.Server server) : base(server)
        {
            Item = item;
        }

        public API.Entities.DroppedItem Item { get; }
    }
}
