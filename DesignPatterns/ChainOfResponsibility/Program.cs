using ChainOfResponsibility.Canonical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2();

            h1.SetSuccessor(h2);

            int[] requests = { 1, 5, 10, 50, 100 }; // 100 not handled at all
            foreach (var request in requests)
            { 
                h1.HandleRequest(request);
            }

            Console.WriteLine();
        }
    }
}
