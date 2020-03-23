using Frostspark.API.Interfaces;
using Frostspark.API.Packets;

namespace Frostspark.API.Classes
{
    /// <summary>
    /// Represents a wrapped Terraria player object.
    /// </summary>
    public abstract class Player : Entity, ICommandSender, ITeleportable
    {
        /// <summary>
        /// Removes this player from the server with an optional message.
        /// </summary>
        /// <param name="reason">Kick reason</param>
        public abstract void Kick(string reason = null);

        /// <summary>
        /// Heals this player. Optional parameters define healing mode.
        /// </summary>
        /// <param name="health">Amount of health to add (or to heal up to)</param>
        /// <param name="is_add">Specifies healing mode. A value of true means <paramref name="health"/> health will be added. A value of false means the player's health will be set to <paramref name="health"/></param>
        public abstract void Heal(int health = 0, bool is_add = false);

        /// <summary>
        /// Hurts this player with a specified amount of damage
        /// </summary>
        /// <param name="damage">Hitpoints of damage to deal</param>
        /// <param name="crit">Whether or not the damage should be critical</param>
        public abstract void Hurt(int damage, bool crit = false);

        /// <summary>
        /// Returns this player's native index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// Returns whether or not this player object has valid connected player backing.
        /// </summary>
        public abstract bool IsValid { get; }

        public abstract string LogName { get; }

        /// <summary>
        /// Sends a string message to this player. Optionally, the unformatted/main color can be set.
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

        /// <summary>
        /// Sends a network packet to this player.
        /// </summary>
        /// <param name="packet">The packet to send</param>
        public abstract void SendPacket(BasePacket packet);
    }
}
