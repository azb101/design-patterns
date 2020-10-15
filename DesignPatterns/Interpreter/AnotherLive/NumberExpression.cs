using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.AnotherLive
{
    // terminal expression
    public class NumberExpression : AbstractExpression
    {
        private string name;

        public NumberExpression(string name)
        {
            this.name = name;
        }

        public override int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}