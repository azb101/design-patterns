using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Live
{
    public class CalculatorCommand : Command
    {
        private char @operator;
        private int operand;
        private Calculator calculator;

        public CalculatorCommand(Calculator calculator,
            char @operator,
            int operand)
        {
            this.operand = operand;
            this.@operator = @operator;
            this.calculator = calculator;
        }

        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        public override void Unexecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new Exception("not supported operation");
            }
        }
    }
}