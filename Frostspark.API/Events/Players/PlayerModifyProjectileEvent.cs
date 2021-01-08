using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Structures;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerModifyProjectileEvent : PlayerEvent, ICancellable, IClientsided
    {
        public PlayerModifyProjectileEvent(Player player, API.Server server, Projectile projectile, ProjectileData new_data) : base(player, server)
        {
            Projectile = projectile;
            NewData = new_data;
        }

        /// <summary>
        /// The projectile the player is updating.
        /// </summary>
        public Projectile Projectile { get; }

        /// <summary>
        /// The new projectile state.
        /// </summary>
        public ProjectileData NewData { get; }

        public bool Cancelled { get; set; }

        public bool Modified { get; set; }
    }
}
