using Frostspark.API.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    /// <summary>
    /// Represents an entity that can be teleported.
    /// </summary>
    public interface ITeleportable
    {
        /// <summary>
        /// Teleports this entity to the given coordinates with an optional teleportation effect.
        /// </summary>
        /// <param name="x">X position to teleport to</param>
        /// <param name="y">Y position to teleport to</param>
        /// <param name="effect">Optional effect. Defines particles and/or sound</param>
        void TeleportToPos(float x, float y, byte effect = 1);

        /// <summary>
        /// Teleports this entity to the given tile coordinates with an optional teleportation effect.
        /// </summary>
        /// <param name="x">Tile X coordinate to teleport to</param>
        /// <param name="y">Tile Y coordinate to teleport to</param>
        /// <param name="effect">Optional effect. Defines particles and/or sound</param>
        void TeleportToTile(int x, int y, byte effect = 1);

        /// <summary>
        /// Teleports this entity to the given entity's position with an optional teleportation effect.
        /// </summary>
        /// <param name="target">The entity to teleport to</param>
        /// <param name="effect">Optional effect. Defines particles and/or sound</param>
        void TeleportToEntity(Entity target, byte effect = 1);
    }
}
