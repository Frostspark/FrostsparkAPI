using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Interfaces
{
    public abstract class IPlayerList
    {
        /// <summary>
        /// Gets a player instance using a native player index. Returns null for offline players.
        /// </summary>
        /// <param name="i">Native Terraria player index</param>
        /// <returns>A wrapped player object</returns>
        public abstract IPlayer this[int i]
        {
            get;
        }

        /// <summary>
        /// Finds the first player that matches the predicate. Returns null if none are found.
        /// </summary>
        /// <param name="predicate">The predicate to attempt to match a player to</param>
        /// <returns>A wrapped player object</returns>
        public abstract IPlayer First(Predicate<IPlayer> predicate);

        /// <summary>
        /// Searches the online playerlist for players that match the predicate. Returns an empty list if none are found.
        /// </summary>
        /// <param name="predicate">The predicate to attempt to match players to</param>
        /// <returns>A list of matching player objects</returns>
        public abstract List<IPlayer> Search(Predicate<IPlayer> predicate);
    }
}
