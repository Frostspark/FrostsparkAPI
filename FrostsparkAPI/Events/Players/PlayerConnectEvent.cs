using System.Net;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player starts connecting to the server.
    /// </summary>
    public class PlayerConnectEvent : PlayerEvent
    {
        public PlayerConnectEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The client version the client is reporting.
        /// </summary>
        public string ClientVersion { get; }

        /// <summary>
        /// The event result. The client is allowed entry if <see cref="Result"/> == <see cref="ConnectResult.Allow"/>
        /// </summary>
        public ConnectResult Result { get; set; }

        /// <summary>
        /// The message displayed to the client if <see cref="Result"/> == <see cref="ConnectResult.KickCustom"/>.
        /// </summary>
        public string KickMessage { get; set; }

        public enum ConnectResult
        {
            Allow,
            KickFull,
            KickBanned,
            KickWhitelist,
            KickCustom
        }
    }
}
