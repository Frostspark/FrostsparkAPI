using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players.Damage
{
    public abstract class PlayerDamageEvent : PlayerEvent, ICancellable
    {
        public PlayerDamageEvent(Player player, API.Server server, int damage, float knockback, HorizontalDirection direction, bool crit) : base(player, server)
        {
            Damage = damage;
            Knockback = knockback;
            Direction = direction;
            Critical = crit;
        }

        public int Damage { get; set; }

        public float Knockback { get; set; }

        public HorizontalDirection Direction { get; set; }

        public bool Critical { get; set; }

        public bool Cancelled { get; set; }
    }
}
