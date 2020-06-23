using Frostspark.API.Entities.Interfaces;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria NPC <see cref="Entity"/> in the world.
    /// </summary>
    public abstract class NPC : Entity, ITeleportable
    {
        public abstract void TeleportToEntity(Entity target, byte effect = 1);

        public abstract void TeleportToPos(float x, float y, byte effect = 1);

        public abstract void TeleportToTile(int x, int y, byte effect = 1);
    }
}
