using System;
using System.Collections.Generic;
using Frostspark.API.Entities;

namespace Frostspark.API.Collections
{
    /// <summary>
    /// Represents an entity list - an abstract wrapper around Terraria's entity arrays.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EntityList<T> where T : Entity
    {
        /// <summary>
        /// Gets an entity instance using a native entity index. Returns null for inactive entities.
        /// </summary>
        /// <param name="i">Native entity index</param>
        /// <returns>A wrapped player object</returns>
        public abstract T this[int i]
        {
            get;
        }

        /// <summary>
        /// Finds the first entity of type <typeparamref name="T"/> that matches the search terms, and returns it.
        /// </summary>
        /// <param name="pred">The search query</param>
        /// <returns>The first entity found, or null if none</returns>
        public abstract T First(Predicate<T> pred);

        /// <summary>
        /// Finds all entities of type <typeparamref name="T"/> that match the search terms, and returns them.
        /// </summary>
        /// <param name="pred">The search query</param>
        /// <returns>A list of 0 or more <typeparamref name="T"/> entities matching the search terms</returns>
        public abstract List<T> Search(Predicate<T> pred);

    }
}
