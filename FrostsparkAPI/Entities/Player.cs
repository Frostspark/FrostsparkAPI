using System.Net;
using Frostspark.API.Entities.Interfaces;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a wrapped Terraria player object.
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

        /// <summary>
        /// Returns this player's native index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// Returns whether or not this player object has valid connected player backing.
        /// </summary>
        public abstract bool IsValid { get; }

        public abstract string LogName { get; }

        public abstract int Health { get; set; }

        /// <summary>
        /// Sends a string message to this player with the specified default colour.
        /// </summary>
        /// <param name="message">The string message to send</param>
        /// <param name="r">Red byte of unformatted text color value</param>
        /// <param name="g">Green byte of unformatted text color value</param>
        /// <param name="b">Blue byte of unformatted text color value</param>
        public abstract void SendMessage(string message, byte r = 255, byte g = 255, byte b = 255);

        public abstract void SendSuccessMessage(string s);

        public abstract void SendErrorMessage(string s);

        public abstract void SendInfoMessage(string s);

        public abstract void TeleportToPos(float x, float y, byte effect = 1);

        public abstract void TeleportToTile(int x, int y, byte effect = 1);

        public abstract void TeleportToEntity(Entity target, byte effect = 1);

        public abstract void Hurt(int damage, bool crit = false);

        public abstract void Kill();

        public abstract void Heal(int health = 0, bool is_add = false);

        /// <summary>
        /// Respawns this player.
        /// </summary>
        public abstract void Respawn();
    }
}
