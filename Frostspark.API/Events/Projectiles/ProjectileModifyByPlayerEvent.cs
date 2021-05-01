using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Structures;

namespace Frostspark.API.Events.Projectiles
{
    public class ProjectileModifyByPlayerEvent : ProjectileEvent, ICancellable, IClientsided, IHasSource<Player>
    {
        public ProjectileModifyByPlayerEvent(Player player, Projectile projectile, ProjectileData new_data, API.Server server) : base(projectile, server)
        {
            Player = player;
            NewData = new_data;
        }

        public Player Player { get; }

        /// <summary>
        /// The new projectile state.
        /// </summary>
        public ProjectileData NewData { get; }

        public bool Cancelled { get; set; }

        public bool Modified { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
