using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Chat
{
    public abstract class ChatManager
    {
        public abstract void BroadcastMessage(string message, Color color);

        public abstract void BroadcastMessage(FormattableString message, Color color);
    }
}
