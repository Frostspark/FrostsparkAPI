using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Worlds
{
    public abstract class TileWire
    {
        public abstract bool this[int index] { get; set; }
    }
}
