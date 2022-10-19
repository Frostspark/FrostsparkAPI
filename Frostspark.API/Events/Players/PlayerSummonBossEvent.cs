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
    public sealed class PlayerSummonBossEvent : PlayerEvent, IHasSource<Player>, ICancellable
    {
        public PlayerSummonBossEvent(BossType type, Player player, API.Server server) : base(player, server)
        {
            Source = player;
            Boss = type;
        }

        public bool Cancelled { get; set; }

        public BossType Boss { get; set; }

        public Player Source { get; set; }
    }
}
