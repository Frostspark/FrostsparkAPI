using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests.Players
{
    public class PlayerChestRenameEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public PlayerChestRenameEvent(string new_name, Player player, Chest chest, API.Server server) : base(chest, server)
        {
            NewName = new_name;
            Player = player;
        }

        public Player Player { get; }

        public string NewName { get; set; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
