using Frostspark.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Structures
{
    public struct BlockShape
    {
        public bool Halfbrick;
        public BlockSlope Slope;

        public static bool operator ==(BlockShape one, BlockShape two)
        {
            return one.Halfbrick == two.Halfbrick && one.Slope == two.Slope;
        }

        public static bool operator !=(BlockShape one, BlockShape two)
        {
            return !(one == two);
        }

        public override bool Equals(object obj)
        {
            if(obj is BlockShape bs)
            {
                return this == bs;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Halfbrick, Slope);
        }
    }
}
