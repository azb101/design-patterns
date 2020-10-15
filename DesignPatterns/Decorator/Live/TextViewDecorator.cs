using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Live
{
    public abstract class TextViewDecorator : TextView
    {
        protected TextView component;

        public void SetComponent(TextView component)
        {
            this.component = component;
        }

        public override void Draw()
        {
            Console.WriteLine("default pre action");
            component.Draw();
        }
    }
}