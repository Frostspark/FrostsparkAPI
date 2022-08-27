using System;
using System.Collections.Generic;

namespace Frostspark.API.Utilities
{
    public static class PaginationUtilities
    {
        /// <summary>
        /// Determines the amount of pages content will be split into given a collection size and page size.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="entries_per_page"></param>
        /// <returns></returns>
        public static int DeterminePageCount(int entries, int entries_per_page = 7)
        {
            return Math.Max((int)Math.Ceiling((double)entries / entries_per_page), 1);
        }

        /// <summary>
        /// Determines if a zero-based page index is valid for a given collection.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="page"></param>
        /// <param name="entries_per_page"></param>
        /// <returns></returns>
        public static bool IsPageValid(int entries, int page, int entries_per_page)
        {
            int max = DeterminePageCount(entries, entries_per_page);
            return page >= 0 && page < max;
        }

        /// <summary>
        /// Returns a slice of the <paramref name="collection"/> paginated with a zero-based page index &amp; amount of entries per page.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="page"></param>
        /// <param name="entries_per_page"></param>
        /// <returns></returns>
        public static IEnumerable<T> Paginate<T>(this IList<T> collection, int page, int entries_per_page = 7)
        {
            int upper_bound = Math.Min((page + 1) * entries_per_page, collection.Count);
            int lower_bound = Math.Max(0, page * entries_per_page);

            for (int x = lower_bound; x < upper_bound; x++)
            {
                yield return collection[x];
            }
        }
    }
}
