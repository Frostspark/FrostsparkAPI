using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Interfaces
{
    public interface IHasTarget<T>
    {
        T Target { get; }
    }
}
