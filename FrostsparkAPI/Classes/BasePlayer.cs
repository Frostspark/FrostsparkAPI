using Frostspark.API.Interfaces;

namespace Frostspark.API.Classes
{
    /// <summary>
    /// Represents a single remote player's session
    /// </summary>
    public abstract class BasePlayer : BaseEntity, ICommandSender, ITeleportable
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

        /// <summary>
        /// Sends a string message to this player. Optionally, the unformatted/main color can be set.
        /// </summary>
        /// <param name="message">The string message to send</param>
        /// <param name="r">Red byte of unformatted text color value</param>
        /// <param name="g">Green byte of unformatted text color value</param>
        /// <param name="b">Blue byte of unformatted text color value</param>
        public abstract void SendMessage(string message, byte r = 255, byte g = 255, byte b = 255);

        /// <summary>
        /// Implements <see cref="ICommandSender.SendSuccessMessage(string)"/>
        /// </summary>
        /// <param name="s"></param>
        public abstract void SendSuccessMessage(string s);

        /// <summary>
        /// Implements <see cref="ICommandSender.SendErrorMessage(string)"/>
        /// </summary>
        /// <param name="s"></param>
        public abstract void SendErrorMessage(string s);

        /// <summary>
        /// Implements <see cref="ICommandSender.SendInfoMessage(string)"/>
        /// </summary>
        /// <param name="s"></param>
        public abstract void SendInfoMessage(string s);

        /// <summary>
        /// Implements <see cref="ITeleportable.TeleportToPos(float, float, byte)"/>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="effect"></param>
        public abstract void TeleportToPos(float x, float y, byte effect = 1);

        /// <summary>
        /// Implements <see cref="ITeleportable.TeleportToTile(int, int, byte)"/>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="effect"></param>
        public abstract void TeleportToTile(int x, int y, byte effect = 1);

        /// <summary>
        /// Implements <see cref="ITeleportable.TeleportToEntity(BaseEntity, byte)"/>
        /// </summary>
        /// <param name="target"></param>
        /// <param name="effect"></param>
        public abstract void TeleportToEntity(BaseEntity target, byte effect = 1);

        /// <summary>
        /// Returns this player's character name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Returns this player's detailed log-name.
        /// </summary>
        public abstract string DetailedName { get; }
    }
}
