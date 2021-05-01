using Frostspark.API.Utilities;

using System;

namespace Frostspark.API.Chat
{
    public abstract class ChatManager
    {
        public abstract void BroadcastMessage(string message, Color color);

        public abstract void BroadcastMessage(FormattableString message, Color color);
    }
}
