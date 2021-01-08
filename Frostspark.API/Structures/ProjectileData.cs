using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Structures
{
    public class ProjectileData
    {
        /// <summary>
        /// The projectile's location
        /// </summary>
        public Vector2D<float> Position { get; set; }

        /// <summary>
        /// The projectile's velocity
        /// </summary>
        public Vector2D<float> Velocity { get; set; }

        /// <summary>
        /// The projectile's damage
        /// </summary>
        public short Damage { get; set; }

        /// <summary>
        /// The projectile's original damage
        /// </summary>
        public short OriginalDamage { get; set; }

        /// <summary>
        /// The projectile's knockback
        /// </summary>
        public float Knockback { get; set; }

        /// <summary>
        /// The projectile's UUID
        /// </summary>
        public short UUID { get; set; }

        /// <summary>
        /// The projectile's AI
        /// </summary>
        public float[] AI { get; set; }

        /// <summary>
        /// The projectile's type
        /// </summary>
        public short NetID { get; set; }
    }
}
