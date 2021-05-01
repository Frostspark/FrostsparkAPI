using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests
{
    public class ChestCloseEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public ChestCloseEvent(Player player, Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public Player Player { get; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
