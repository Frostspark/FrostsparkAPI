using Frostspark.API.Structures;

namespace Frostspark.API.Entities.Interfaces
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
        /// <param name="info">Parameters of the teleportation event.</param>
        void TeleportToPos(float x, float y, TeleportationInfo info = default);

        /// <summary>
        /// Teleports this entity to the given tile coordinates with an optional teleportation effect.
        /// </summary>
        /// <param name="x">Tile X coordinate to teleport to</param>
        /// <param name="y">Tile Y coordinate to teleport to</param>
        /// <param name="info">Parameters of the teleportation event.</param>
        void TeleportToTile(int x, int y, TeleportationInfo info = default);

        /// <summary>
        /// Teleports this entity to the given entity's position with an optional teleportation effect.
        /// </summary>
        /// <param name="target">The entity to teleport to</param>
        /// <param name="info">Parameters of the teleportation event.</param>
        void TeleportToEntity(Entity target, TeleportationInfo info = default);
    }
}
