using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Live
{
    public class RichTextView : TextView
    {
        public override void Draw()
        {
            Console.WriteLine($"drawing: {nameof(RichTextView)}");
        }
    }
}