using Frostspark.API.Entities.Interfaces;
using Frostspark.API.Structures;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria NPC <see cref="Entity"/> in the world.
    /// </summary>
    public abstract class NPC : Entity, ITeleportable
    {
        public abstract void TeleportToEntity(Entity target, TeleportationInfo info = default);

        public abstract void TeleportToPos(float x, float y, TeleportationInfo info = default);

        public abstract void TeleportToTile(int x, int y, TeleportationInfo info = default);
    }
}
