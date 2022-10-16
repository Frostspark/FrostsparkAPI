using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items.Players
{
    public sealed class PlayerDroppedItemCreateEvent : DroppedItemCreateEvent, IHasSource<Player>
    {
        public PlayerDroppedItemCreateEvent(Player source, DroppedItem item, API.Server server) : base(item, server)
        {
            Source = source;
        }

        public Player Source { get; set; }
    }
}
