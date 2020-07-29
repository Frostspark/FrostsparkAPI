using System.Net;
using Frostspark.API.Entities.Interfaces;
using Frostspark.API.Structures;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria player <see cref="Entity"/> in the world.
    /// </summary>
    public abstract partial class Player : Entity, ICommandSender, ITeleportable, ILiving
    {
        /// <summary>
        /// The IP <see cref="EndPoint"/> (address + port) this player is connected from.
        /// </summary>
        public abstract IPEndPoint IP { get; protected set; }

        /// <summary>
        /// Removes this player from the server with an optional message.
        /// </summary>
        /// <param name="reason">Kick reason</param>
        public abstract void Kick(string reason = null);

        public abstract string LogName { get; }

        public abstract int Health { get; set; }

        public abstract int MaxHealth { get; set; }

        /// <summary>
        /// Sends a string message to this player with the specified default colour.
        /// </summary>
        /// <param name="message">The string message to send</param>
        /// <param name="color">The base color of the message</param>
        public abstract void SendMessage(string message, Utilities.Color color);

        public abstract void SendSuccessMessage(string s);

        public abstract void SendErrorMessage(string s);

        public abstract void SendInfoMessage(string s);

        public abstract void TeleportToPos(float x, float y, TeleportationInfo info = default);

        public abstract void TeleportToTile(int x, int y, TeleportationInfo info = default);

        public abstract void TeleportToEntity(Entity target, TeleportationInfo info = default);

        public abstract void Hurt(int damage, bool crit = false);

        public abstract void Kill();

        public abstract void Heal(int health = 0, bool is_add = false);

        /// <summary>
        /// Respawns this player.
        /// </summary>
        public abstract void Respawn();

        public abstract bool HasPermission(string perm);

        /// <summary>
        /// Whether or not this player is considered a server operator and has all permissions.
        /// </summary>
        public abstract bool Operator { get; set; }
    }
}
