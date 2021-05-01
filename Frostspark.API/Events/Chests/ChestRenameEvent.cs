using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests
{
    public class ChestRenameEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public ChestRenameEvent(Player player, Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public Player Player { get; }

        public string NewName { get; set; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
