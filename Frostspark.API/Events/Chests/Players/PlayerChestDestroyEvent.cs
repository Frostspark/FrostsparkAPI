using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chests.Players
{
    public sealed class PlayerChestDestroyEvent : ChestDestroyEvent, IHasSource<Player>
    {
        public PlayerChestDestroyEvent(Player source, Chest chest, API.Server server) : base(chest, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
