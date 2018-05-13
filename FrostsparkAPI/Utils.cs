﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API
{
    public static class Utils
    {
        /// <summary>
        /// Throws an exception is the specified predicate is not true.
        /// </summary>
        /// <param name="predicate">Predicate to be asserted</param>
        /// <param name="failureMessage">Exception message to use if assert fails</param>
        public static void AssertState(Func<bool> predicate, string failureMessage)
        {
            if(!predicate())
            {
                throw new InvalidOperationException(failureMessage);
            }
        }
    }
}
