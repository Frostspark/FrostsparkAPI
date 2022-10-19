using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chests.Players
{
    public sealed class PlayerChestUnlockEvent : ChestEvent, IHasSource<Player>, ICancellable
    {
        public PlayerChestUnlockEvent(Player source, Chest chest, API.Server server) : base(chest, server)
        {
            Source = source;
        }

        public bool Cancelled { get; set; }

        public Player Source { get; }
    }
}
