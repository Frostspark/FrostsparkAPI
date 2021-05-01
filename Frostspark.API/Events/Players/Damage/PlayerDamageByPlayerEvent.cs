using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Players.Damage
{
    public class PlayerDamageByPlayerEvent : PlayerDamageEvent, IHasSource<Player>
    {
        public PlayerDamageByPlayerEvent(Player player, Player attacker, API.Server server, int damage, float knockback, HorizontalDirection direction, bool crit) : base(player, server, damage, knockback, direction, crit)
        {
            Attacker = attacker;
        }

        public Player Attacker { get; }

        Player IHasSource<Player>.Source => Attacker;
    }
}
