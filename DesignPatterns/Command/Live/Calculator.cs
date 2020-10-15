using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Live
{
    public class Calculator
    {
        private int curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    curr += operand;
                    break;

                case '-':
                    curr -= operand;
                    break;

                case '*':
                    curr *= operand;
                    break;

                case '/':
                    curr /= operand;
                    break;

                default: throw new Exception("not supported operation");
            }

            Console.WriteLine($"After {@operator} {operand} value become : {curr}");
        }
    }
}