using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Canonical
{
    internal class ConcreteComponentA : Component
    {
        public override void Operation()
        {
            Console.WriteLine($"{nameof(ConcreteComponentA)} operation is performing");
        }
    }
}