using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Canonical
{
    public class DecoratorWithPostOperation : Decorator
    {
        public override void Operation()
        {
            if (component == null)
                return;

            component.Operation();
            Console.WriteLine($"{nameof(DecoratorWithPostOperation)} post operation");
        }
    }
}