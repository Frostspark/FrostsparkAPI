using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class PlayerSummonEntitySource : EntitySource
    {
        public Player Summoner { get; private set; }

        public PlayerSummonEntitySource(Player player)
        {
            Summoner = player;
        }
    }
}
