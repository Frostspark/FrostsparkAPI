using Frostspark.API.Interfaces;
using System;

namespace Frostspark.API
{
    public static class Frostspark
    {
        private static IAPIProvider APIProviderInst;
        internal static IAPIProvider APIProvider
        {
            get
            {
                AssertAPIState(true);
                return APIProviderInst;
            }
            set
            {
                AssertAPIState(false);
                Initialize();
                APIProviderInst = value;
            }
        }

        private static IPlayerList PlayersInst;
        public static IPlayerList Players
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
                Utils.AssertState(() => APIProviderInst != null, "The API has not been initialized yet!");
            else
                Utils.AssertState(() => APIProviderInst == null, "The API has already been initialized!");
        }

        private static void Initialize()
        {
            PlayersInst = APIProvider.PlayerList;
        }
    }
}
