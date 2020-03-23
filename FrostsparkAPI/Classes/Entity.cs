using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Classes
{
    public abstract class Entity
    {
        /// <summary>
        /// Kills this entity.
        /// </summary>
        public abstract void Kill();

        /// <summary>
        /// Returns this entity's name.
        /// </summary>
        public abstract string Name { get; }
    }
}
