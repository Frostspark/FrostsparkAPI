using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests.Players
{
    public class PlayerChestUpdateItemEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public PlayerChestUpdateItemEvent(Player player, Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public Player Player { get; }

        public Inventories.ItemStack Item { get; set; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
