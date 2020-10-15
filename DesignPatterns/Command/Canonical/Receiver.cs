using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Canonical
{
    public class Receiver : IReceiver
    {
        public void Run()
        {
            Console.WriteLine("Receiver.Run() is performing");
        }
    }
}