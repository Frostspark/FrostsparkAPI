using Frostspark.API.Classes;
using Frostspark.API.Events;
using Frostspark.API.Interfaces;
using System;

namespace Frostspark.API
{
    /// <summary>
    /// The main API class. Contains static fields allowing easy access to important API facilities.
    /// </summary>
    public static class Frostspark
    {
        private static Server ServerInst;
        internal static Server Server
        {
            get
            {
                AssertAPIState(true);
                return ServerInst;
            }
            set
            {
                AssertAPIState(false);
                Initialize();
                ServerInst = value;
            }
        }

        private static PlayerList PlayersInst;
        public static PlayerList Players
        {
            get
            {
                AssertAPIState(true);
                return PlayersInst;
            }
            set
            {
                AssertAPIState(false);
                PlayersInst = value;
            }
        }



        private static void AssertAPIState(bool init)
        {
            if (init)
                Utils.AssertState(() => ServerInst != null, "The server API has not been initialized yet!");
            else
                Utils.AssertState(() => ServerInst == null, "The server API has already been initialized!");
        }

        private static void Initialize()
        {
            PlayersInst = Server.PlayerList;
        }
    }
}
