using Frostspark.API.Utilities;

using System;

namespace Frostspark.API.Entities.Interfaces
{
    public interface ICommandSender
    {
        /// <summary>
        /// Returns the sender's log-friendly name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Returns the sender's detailed descriptor used for logging (type of sender, name (if applicable) and coordinates (if it's a block executing commands))
        /// </summary>
        string LogName { get; }

        /// <summary>
        /// Sends a success message to this command sender.
        /// </summary>
        /// <param name="msg">The message string</param>
        void SendSuccessMessage(string msg);

        /// <summary>
        /// Sends an error message to this command sender.
        /// </summary>
        /// <param name="msg">The message string</param>
        void SendErrorMessage(string msg);

        /// <summary>
        /// Sends an info message to this command sender.
        /// </summary>
        /// <param name="msg">The message string</param>
        void SendInfoMessage(string msg);

        /// <summary>
        /// Sends a formatted message to this command sender.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        void SendFormattedMessage(FormattableString message, Color color);

        /// <summary>
        /// Determines if the sender has a given permission
        /// </summary>
        /// <param name="perm">The permission to check</param>
        /// <returns></returns>
        bool HasPermission(string perm);
    }
}
