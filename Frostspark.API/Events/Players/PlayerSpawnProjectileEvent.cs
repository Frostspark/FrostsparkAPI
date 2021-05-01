using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Structures;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    /// * Note: This class should be called ProjectileSpawnByPlayerEvent and reside in the Projectiles namespace.
    /// However, due to how projectile spawning works in the Frostspark.Server engine, the data is vetted first before creating a projectile (whereas any ProjectileEvent requires an instance of a projectile)
    /// For performance reasons, we don't want to allocate a projectile (and generally, "trouble" the server engine) with projectiles that may be sent in rapidly and rejected just as fast.
    /// This event also violates the naming scheme of other events: [TargetEntity][Action]{Description}Event.
    /// This has to be resolved in the future: I'm open to suggestions.
    public class PlayerSpawnProjectileEvent : PlayerEvent, ICancellable, IClientsided
    {
        public PlayerSpawnProjectileEvent(Player player, API.Server server, ProjectileData spawn_information) : base(player, server)
        {
            ProjectileSpawnInformation = spawn_information;
        }

        /// <summary>
        /// Information about the projectile that will be spawned.
        /// </summary>
        public ProjectileData ProjectileSpawnInformation { get; }

        public bool Cancelled { get; set; }

        public bool Modified { get; set; }
    }
}
