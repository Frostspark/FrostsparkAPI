using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Collections
{
    /// <summary>
    /// Represents a tile entity list - an abstract wrapper around Terraria's TileEntity class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TileEntityList
    {
        /// <summary>
        /// Gets an entity instance using a native entity index. Returns null for inactive entities.
        /// </summary>
        /// <param name="i">Native entity index</param>
        /// <returns>A wrapped TileEntity object, or null if inactive</returns>
        public abstract TileEntity this[int i]
        {
            get;
        }

        /// <summary>
        /// Gets an entity instance using a coordinate pair. Returns null when not found.
        /// </summary>
        /// <param name="x">The X coordinate</param>
        /// <param name="y">The Y coordinate</param>
        /// <returns>The entity at this location, or null if not found</returns>
        public abstract TileEntity this[int x, int y]
        {
            get;
        }

        /// <summary>
        /// Finds the first entity of type <typeparamref name="T"/> that matches the search terms, and returns it.
        /// </summary>
        /// <param name="pred">The search query</param>
        /// <returns>The first entity found, or null if none</returns>
        public abstract TileEntity First(Predicate<TileEntity> pred);

        /// <summary>
        /// Finds all entities of type <typeparamref name="T"/> that match the search terms, and returns them.
        /// </summary>
        /// <param name="pred">The search query</param>
        /// <returns>A list of 0 or more <typeparamref name="T"/> entities matching the search terms</returns>
        public abstract List<TileEntity> Search(Predicate<TileEntity> pred);
    }
}
