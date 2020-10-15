using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Live
{
    public class TextViewDashedBorderDecorator : TextViewDecorator
    {
        public override void Draw()
        {
            component.Draw();
            Console.WriteLine("make border dashed");
        }
    }
}