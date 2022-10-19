using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public sealed class PlayerStartWorldEvent : PlayerEvent, IHasSource<Player>, ICancellable
    {
        public PlayerStartWorldEvent(WorldEventType world_event, Player player, API.Server server) : base(player, server)
        {
            Source = player;
            Event = world_event;
        }

        public bool Cancelled { get; set; }

        public WorldEventType Event { get; }

        public Player Source { get; }
    }
}
