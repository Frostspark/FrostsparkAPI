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
