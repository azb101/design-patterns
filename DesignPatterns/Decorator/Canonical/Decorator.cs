using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Canonical
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component == null)
                return;

            Console.WriteLine("base decorator: pre operation");
            component.Operation();
            Console.WriteLine("base decorator: post operation");
        }
    }
}