using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Canonical
{
    internal class ConcreteComponentB : Component
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(ConcreteComponentB)} operation is performing");
        }
    }
}