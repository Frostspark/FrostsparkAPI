using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    public abstract class IPlayerList
    {
        public abstract IPlayer this[int i]
        {
            get;
        }
    }
}
