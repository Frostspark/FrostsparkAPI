using Frostspark.API.Classes;
using Frostspark.API.Events;
using System;

namespace Frostspark.API
{
    /// <summary>
    /// The main API class. Contains static fields allowing easy access to important API facilities.
    /// </summary>
    public static class Frostspark
    {
        private static Server ServerInst;
        public static Server Server
        {
            get
            {
                AssertAPIState(true);
                return ServerInst;
            }
            internal set
            {
                AssertAPIState(false);
                Initialize();
                ServerInst = value;
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

        }
    }
}
