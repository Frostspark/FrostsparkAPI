using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Inventories
{
    public abstract class Inventory
    {
        /// <summary>
        /// The inventory's size (amount of <see cref="ItemStack"/> slots)
        /// </summary>
        public abstract int Size { get; }

        /// <summary>
        /// Retrieves or sets an item inside this inventory.
        /// </summary>
        /// <param name="slot">The item slot</param>
        /// <returns></returns>
        public abstract ItemStack this[int slot] { get; set; }
    }
}
