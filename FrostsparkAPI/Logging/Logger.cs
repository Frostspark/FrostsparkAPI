using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Logging
{
    public abstract class Logger
    {
        public abstract void LogInfo(string msg);

        public abstract void LogWarning(string msg);

        public abstract void LogError(string msg);

        public abstract void LogDebug(string msg);

        public abstract void LogSuccess(string msg);

    }
}
