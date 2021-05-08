using Frostspark.API.Utilities;

using System;
using System.Threading.Tasks;

namespace Frostspark.API
{
    /// <summary>
    /// The main API class. Contains static fields allowing easy access to important API facilities.
    /// </summary>
    public static class Frostspark
    {
        private static bool Initialized;

        private static Server Instance;

        public static Server Server
        {
            get
            {
                AssertAPIState(true);
                return Instance;
            }
            internal set
            {
                AssertAPIState(false);
                Instance = value;
            }
        }

        private static void AssertAPIState(bool init)
        {
            if (init)
                Assert.State(() => Instance != null, "The server API has not been initialized yet!");
            else
                Assert.State(() => Instance == null, "The server API has already been initialized!");
        }

        public static async Task Initialize(Server server)
        {
            if (Initialized)
            {
                throw new InvalidOperationException("The API is already initialised.");
            }

            Server = server;
            await Server.Initialize();

            Initialized = true;
        }
    }
}
