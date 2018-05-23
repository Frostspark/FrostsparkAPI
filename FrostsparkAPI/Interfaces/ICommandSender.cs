using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    public abstract class ICommandSender
    {
        /// <summary>
        /// Sends a string message to this player. Optionally, the unformatted/main color can be set.
        /// </summary>
        /// <param name="message">The string message to send</param>
        /// <param name="r">Red byte of unformatted text color value</param>
        /// <param name="g">Green byte of unformatted text color value</param>
        /// <param name="b">Blue byte of unformatted text color value</param>
        public abstract void SendMessage(string message, byte r = 255, byte g = 255, byte b = 255);
    }
}
