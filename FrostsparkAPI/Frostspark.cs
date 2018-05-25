using Frostspark.API.Interfaces;
using System;

namespace Frostspark.API
{
    public static class Frostspark
    {
        private static BaseServer ServerInst;
        internal static BaseServer Server
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

        private static BasePlayerList PlayersInst;
        public static BasePlayerList Players
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
