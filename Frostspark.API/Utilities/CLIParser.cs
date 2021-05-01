using System.Collections.Generic;

namespace Frostspark.API.Utilities
{
    public class CLIParser
    {
        private Dictionary<string, string> Params = new Dictionary<string, string>();

        public void Load(string[] commandline)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

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
                    parameters.Add(current_key, arg);
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
            return Params.TryGetValue(flag, out value);
        }
    }
}
