using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Canonical
{
    public class DecoratorWithPreOperation : DecoratorWithPostOperation
    {
        public override void Operation()
        {
            if (component == null)
                return;

            Console.WriteLine($"{nameof(DecoratorWithPreOperation)} pre operation");
            component.Operation();
        }
    }
}