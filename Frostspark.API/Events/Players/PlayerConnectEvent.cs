using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player starts connecting to the server.
    /// </summary>
    public class PlayerConnectEvent : PlayerEvent
    {
        public PlayerConnectEvent(Player player, byte slot, API.Server server) : base(player, server)
        {
            Slot = slot;
        }

        /// <summary>
        /// The event result. The client is allowed entry if <see cref="Result"/> == <see cref="ConnectResult.Allow"/>
        /// </summary>
        public ConnectResult Result { get; set; }

        /// <summary>
        /// The message displayed to the client if <see cref="Result"/> == <see cref="ConnectResult.KickCustom"/>.
        /// </summary>
        public string KickMessage { get; set; }

        /// <summary>
        /// The slot this player was assigned.
        /// </summary>
        public byte Slot { get; }

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
