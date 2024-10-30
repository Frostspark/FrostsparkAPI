using Frostspark.API.Plugins;
using Frostspark.API.Structures;
using Frostspark.API.Utilities;

using System;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents an instance of an entity in Terraria's engine.
    /// </summary>
    public abstract class Entity
    {
        internal Entity()
        {
            Metadata = new MetadataStore();
        }

        /// <summary>
        /// The metadata store for key-value information storage.
        /// </summary>
        protected MetadataStore Metadata;

        /// <summary>
        /// Removes this entity.
        /// </summary>
        public abstract void Remove();

        /// <summary>
        /// This entity's name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// This entity's position in the world.
        /// </summary>
        public abstract Vector2D<float> Position { get; }

        /// <summary>
        /// This entity's velocity.
        /// </summary>
        public abstract Vector2D<float> Velocity { get; }

        /// <summary>
        /// This entity's native handle index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// Whether or not this entity is still in the game world.
        /// <para>This is not synonymous with the native index being active, but rather with one specific instance occupying that index.</para>
        /// This means that once this entity is removed, and its index reassigned, this will still return false.
        /// </summary>
        public abstract bool Active { get; }

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
            ArgumentNullException.ThrowIfNull(plugin);

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
            ArgumentNullException.ThrowIfNull(plugin);

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
            ArgumentNullException.ThrowIfNull(plugin);

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

        protected void ClearPluginData(Plugin plugin)
        {
            Metadata.ClearPluginData(plugin);
        }
    }
}
