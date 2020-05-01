using System.Net;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player starts connecting to the server.
    /// </summary>
    public class PlayerConnectEvent : Event
    {
        public PlayerConnectEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The player that's connecting
        /// </summary>
        public Player Player { get; }

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
