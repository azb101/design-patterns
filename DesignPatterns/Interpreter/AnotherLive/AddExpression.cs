using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.AnotherLive
{
    // non terminal expression
    public class AddExpression : AbstractExpression
    {
        public AbstractExpression expression1 { get; set; }
        public AbstractExpression expression2 { get; set; }

        public override int Interpret(Context context)
        {
            return expression1.Interpret(context) + expression2.Interpret(context);
        }
    }
}