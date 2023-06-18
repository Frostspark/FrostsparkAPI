using Frostspark.API.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities
{
    public abstract class Sign
    {
        /// <summary>
        /// Whether or not this entity is still in the game world.
        /// <para>This is not synonymous with the native index being active, but rather with one specific instance occupying that index.</para>
        /// This means that once this entity is removed, and its index reassigned, this will still return false.
        /// </summary>
        public abstract bool Active { get; }

        /// <summary>
        /// This <see cref="Sign"/>'s native index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// This <see cref="Sign"/>'s position in the world.
        /// </summary>
        public abstract Vector2D<int> Position { get; }

        /// <summary>
        /// This <see cref="Sign"/>'s hitbox.
        /// </summary>
        public abstract Rectangle Hitbox { get; }

        /// <summary>
        /// This <see cref="Sign" />'s text.
        /// </summary>
        public abstract string Text { get; set; }

        /// <summary>
        /// Removes this <see cref="Sign"/> from the world.
        /// </summary>
        public abstract void Remove();
    }
}
