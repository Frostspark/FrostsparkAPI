using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Chests
{
    public class ChestOpenEvent : ChestEvent, ICancellable, IHasSource<Player>
    {
        public ChestOpenEvent(Player player, Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public Player Player { get; }

        /// <summary>
        /// Whether or not the opening action is canceled.
        /// </summary>
        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
