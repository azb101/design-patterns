using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.AnotherLive
{
    public abstract class AbstractExpression
    {
        public abstract int Interpret(Context context);
    }
}