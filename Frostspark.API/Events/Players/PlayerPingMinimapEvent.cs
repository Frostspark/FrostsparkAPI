using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

namespace Frostspark.API.Events.Players
{
    public class PlayerPingMinimapEvent : PlayerEvent, ICancellable
    {
        public PlayerPingMinimapEvent(Player player, API.Server server) : base(player, server)
        {
        }

        public Vector2D<int> Position { get; set; }

        public bool Cancelled { get; set; }
    }
}
