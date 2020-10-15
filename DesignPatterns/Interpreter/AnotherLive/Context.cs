using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.AnotherLive
{
    public class Context
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>();

        public void SetVariable(string name, int var)
        {
            if (dict.ContainsKey(name))
                dict[name] = var;
            else
                dict.Add(name, var);
        }

        public int GetVariable(string name)
        {
            return dict[name];
        }
    }
}