using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    /// <summary>
    /// Represents a single remote player's session
    /// </summary>
    public abstract class IPlayer : ICommandSender
    {
        /// <summary>
        /// Kills this player.
        /// </summary>
        public abstract void Kill();

        /// <summary>
        /// Removes this player from the server with an optional message.
        /// </summary>
        /// <param name="reason">Kick reason</param>
        public abstract void Kick(string reason = null);

        /// <summary>
        /// Teleports this player to the given coordinates with an optional teleportation effect.
        /// </summary>
        /// <param name="x">X position to teleport to</param>
        /// <param name="y">Y position to teleport to</param>
        /// <param name="effect">Optional effect. Defines particles and/or sound</param>
        public abstract void TeleportToPos(float x, float y, byte effect = 1);

        /// <summary>
        /// Teleports this player to the given tile coordinates with an optional teleportation effect.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="effect"></param>
        public abstract void TeleportToTile(int x, int y, byte effect = 1);

        /// <summary>
        /// Teleports this player to the given player's position with an optional teleportation effect.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="effect"></param>
        public abstract void TeleportToPlayer(IPlayer target, byte effect = 1);

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
    }
}
