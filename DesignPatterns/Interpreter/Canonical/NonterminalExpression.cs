using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Canonical
{
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context content)
        {
            Console.WriteLine("Calle NonTerminal.Interper");
        }
    }
}