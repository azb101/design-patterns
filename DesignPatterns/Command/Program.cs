using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Canonical;
using Command.Live;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical
            var rec = new Receiver();
            var command = new ConcreteCommand(rec);
            var invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            Console.WriteLine();

            // live
            var user = new User();
            user.Compute('+', 100);
            user.Compute('-', 30);
            user.Compute('*', -1);

            user.Undo(3);
            user.Undo(3);

            user.Redo(2);
            user.Redo(2);
            user.Redo(2);
        }
    }
}