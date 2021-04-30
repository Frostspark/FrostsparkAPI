using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Signifies the event has a source of type <typeparamref name="SourceType"/>
    /// </summary>
    /// <typeparam name="SourceType"></typeparam>
    public interface IHasSource<SourceType>
    {
        SourceType Actor { get; }
    }
}
