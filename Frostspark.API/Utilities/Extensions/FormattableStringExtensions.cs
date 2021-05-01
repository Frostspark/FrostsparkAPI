
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Frostspark.API.Utilities.Extensions
{
    public static class FormattableStringExtensions
    {
        public static FormattableString Join(string separator, IEnumerable<FormattableString> strings)
        {
            StringBuilder sb = new StringBuilder();
            List<FormattableString> fmts = new List<FormattableString>();
            int id = 0;

            using var enumerator = strings.GetEnumerator();

            if (!enumerator.MoveNext())
                return $"";

            if (enumerator.Current != null)
            {
                sb.Append($"{{{id}}}");
                fmts.Add(enumerator.Current);
                id++;
            }

            while (enumerator.MoveNext())
            {
                sb.Append(separator);

                if (enumerator.Current != null)
                {
                    sb.Append($"{{{id}}}");
                    fmts.Add(enumerator.Current);
                    id++;
                }
            }

            return FormattableStringFactory.Create(sb.ToString(), fmts.ToArray());
        }
    }
}
