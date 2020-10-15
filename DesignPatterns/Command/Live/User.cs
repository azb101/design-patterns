using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Live
{
    public class User
    {
        private Calculator calculator = new Calculator();
        private List<Command> commands = new List<Command>();
        private int current;

        public void Compute(char @operator, int operand)
        {
            var command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();

            commands.Add(command);
            current++;
        }

        public void Redo(int levels)
        {
            Console.WriteLine($"Redo several commands: {levels}");

            for (int i = 0; i < levels; i++)
            {
                if (current <= commands.Count - 1)
                {
                    var command = commands[current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"Undo several commands: {levels}");

            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    var command = commands[--current];
                    command.Unexecute();
                }
            }
        }
    }
}