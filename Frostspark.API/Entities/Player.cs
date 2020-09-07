using System;
using System.Net;

using Frostspark.API.Entities.Interfaces;
using Frostspark.API.Plugins;
using Frostspark.API.Structures;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria player <see cref="Entity"/> in the world.
    /// </summary>
    public abstract partial class Player : Entity, ICommandSender, ITeleportable, ILiving
    {
        /// <summary>
        /// The metadata store for key-value information storage.
        /// </summary>
        protected MetadataStore Metadata;

        /// <summary>
        /// The IP <see cref="EndPoint"/> (address + port) this player is connected from.
        /// </summary>
        public abstract IPEndPoint RemoteAddress { get; protected set; }

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

        /// <summary>
        /// Retrieves a metadata value from this player at the specified key.
        /// </summary>
        /// <typeparam name="T">The data type</typeparam>
        /// <param name="plugin">The plugin calling this method.</param>
        /// <param name="global">Whether the metadata node is global or plugin-local.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value output. <see cref="default"/> if not found.</param>
        /// <returns>Whether or not the value exists and was assigned to <paramref name="value"/></returns>
        public bool GetMetadata<T>(Plugin plugin, bool global, string key, out T value)
        {
            if (plugin == null)
                throw new ArgumentNullException("The plugin instance cannot be null!");

            if (global)
            {
                return Metadata.GetGlobalValue(key, out value);
            }
            else
            {
                return Metadata.GetLocalValue(plugin, key, out value);
            }

        }

        /// <summary>
        /// Assigns a metadata value to this player at the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="plugin">The plugin calling this method.</param>
        /// <param name="global">Whether the metadata node is global or plugin-local.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value output. <see cref="default"/> if not found.</param>
        public void SetMetadata<T>(Plugin plugin, bool global, string key, T value)
        {
            if (plugin == null)
                throw new ArgumentNullException("The plugin instance cannot be null!");

            if (global)
            {
                Metadata.SetGlobalValue(plugin, key, value);
            }
            else
            {
                Metadata.SetLocalValue(plugin, key, value);
            }
        }

        /// <summary>
        /// Clears a metadata value from this player at the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="plugin">The plugin calling this method.</param>
        /// <param name="global">Whether the metadata node is global or plugin-local.</param>
        /// <param name="key">The key.</param>
        /// <returns>Whether or not a value was removed.</returns>
        public bool ClearMetadata<T>(Plugin plugin, bool global, string key)
        {
            if (plugin == null)
                throw new ArgumentNullException("The plugin instance cannot be null!");

            if (global)
            {
                return Metadata.ClearGlobalValue(key);
            }
            else
            {
                return Metadata.ClearLocalValue(plugin, key);
            }
        }

        protected bool GetGlobalMetadata<T>(string key, out T value)
        {
            return Metadata.GetGlobalValue(key, out value);
        }

        protected void SetGlobalMetadata<T>(string key, T value)
        {
            Metadata.SetGlobalValue(null, key, value);
        }

        protected bool ClearGlobalMetadata(string key)
        {
            return Metadata.ClearGlobalValue(key);
        }
    }
}
