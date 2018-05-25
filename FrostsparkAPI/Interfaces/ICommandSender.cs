using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    public interface ICommandSender
    {
        /// <summary>
        /// Returns the sender's log-friendly name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Returns the sender's detailed log-name (type of sender, name (if applicable) and coordinates (if it's a tile))
        /// </summary>
        string DetailedName { get; }

        /// <summary>
        /// Sends a success message to this command sender.
        /// </summary>
        /// <param name="s">The message string</param>
        void SendSuccessMessage(string s);

        /// <summary>
        /// Sends an error message to this command sender.
        /// </summary>
        /// <param name="s">The message string</param>
        void SendErrorMessage(string s);

        /// <summary>
        /// Sends an info message to this command sender.
        /// </summary>
        /// <param name="s">The message string</param>
        void SendInfoMessage(string s);
    }
}
