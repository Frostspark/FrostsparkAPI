using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerHitBlockEvent : PlayerEvent
    {
        public PlayerHitBlockEvent(Player player, API.Server server) : base(player, server)
        {
        }


    }
}
