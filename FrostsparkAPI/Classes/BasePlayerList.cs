using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    public abstract class BasePlayerList
    {
        /// <summary>
        /// Gets a player instance using a native player index. Returns null for offline players.
        /// </summary>
        /// <param name="i">Native Terraria player index</param>
        /// <returns>A wrapped player object</returns>
        public abstract BasePlayer this[int i]
        {
            get;
        }

        /// <summary>
        /// Finds the first player that matches the predicate. Returns null if none are found.
        /// </summary>
        /// <param name="predicate">The predicate to attempt to match a player to</param>
        /// <returns>A wrapped player object</returns>
        public abstract BasePlayer First(Predicate<BasePlayer> predicate);

        /// <summary>
        /// Searches the online playerlist for players that match the predicate. Returns an empty list if none are found.
        /// </summary>
        /// <param name="predicate">The predicate to attempt to match players to</param>
        /// <returns>A list of matching player objects</returns>
        public abstract List<BasePlayer> Search(Predicate<BasePlayer> predicate);
    }
}
