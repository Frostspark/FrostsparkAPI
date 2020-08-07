
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Utilities.Extensions
{
    public class FormattableStringExtensions
    {
        public static FormattableString Join(string separator, IEnumerable<FormattableString> strings)
        {
            StringBuilder sb = new StringBuilder();
            List<FormattableString> fmts = new List<FormattableString>();
            int id = 0;

            using (var enumerator = strings.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return $"";

                if (enumerator.Current != null)
                {
                    sb.Append($"{{{id}}}");
                    id++;
                }

                while (enumerator.MoveNext())
                {
                    sb.Append(separator);

                    if (enumerator.Current != null)
                    {
                        sb.Append($"{{{id}}}");
                        id++;
                    }
                }

            }

            return FormattableStringFactory.Create(sb.ToString(), fmts);

        }
    }
}
