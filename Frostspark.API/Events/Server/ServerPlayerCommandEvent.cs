using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Server
{
    public class ServerPlayerCommandEvent : ServerCommandEvent, IHasSource<Player>
    {
        public ServerPlayerCommandEvent(Player player, string command, API.Server server) : base(command, server)
        {
            Player = player;
        }

        public Player Player { get; }

        Player IHasSource<Player>.Source => Player;
    }
}
