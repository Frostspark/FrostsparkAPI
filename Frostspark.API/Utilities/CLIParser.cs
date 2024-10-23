using System.Collections.Generic;

namespace Frostspark.API.Utilities
{
    public class CLIParser
    {
        private Dictionary<string, List<string>> Params = new Dictionary<string, List<string>>();

        public void Load(string[] commandline)
        {
            Dictionary<string, List<string>> parameters = new Dictionary<string, List<string>>();

            string current_key = null;

            for (int i = 0; i < commandline.Length; i++)
            {
                var arg = commandline[i];

                if (arg.StartsWith("-"))
                {
                    if (current_key != null)
                    {
                        parameters.Add(current_key, null);
                    }

                    current_key = arg;
                }
                else if (current_key != null)
                {
                    parameters.TryAdd(current_key, new List<string>());
                    parameters[current_key].Add(arg);
                    current_key = null;
                }
            }

            Params = parameters;
        }

        public bool IsSet(string flag)
        {
            return Params.ContainsKey(flag);
        }

        public bool GetValue(string flag, out string value)
        {
            value = null;

            if (Params.TryGetValue(flag, out var values) && values.Count > 0)
            {
                value = values[0];
                return true;
            }

            return false;
        }

        public bool GetValues(string flag, out List<string> values)
        {
            return Params.TryGetValue(flag, out values);
        }
    }
}
