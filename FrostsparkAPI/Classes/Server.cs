using Frostspark.API.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    /// <summary>
    /// Represents an underlying server engine.
    /// </summary>
    public abstract class Server
    {
        public abstract EntityList<Player> Players { get; }

        public abstract EntityList<NPC> NPCs { get; }

        public abstract EntityList<Projectile> Projectiles { get; }

        public abstract EntityList<Item> Items { get; }

    }
}
