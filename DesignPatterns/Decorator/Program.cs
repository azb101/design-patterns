using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Canonical;
using Decorator.Live;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical example
            var c1 = new ConcreteComponentA();
            var d1 = new DecoratorWithPreOperation();
            var d2 = new DecoratorWithPostOperation();

            d1.SetComponent(c1);
            d2.SetComponent(d1);
            d2.Operation();

            // live example
            Console.WriteLine();

            var textView = new RichTextView();
            var borderedTextView = new TextViewBorderDecorator();
            var dashedBorderedTextView = new TextViewDashedBorderDecorator();

            borderedTextView.SetComponent(textView);
            dashedBorderedTextView.SetComponent(borderedTextView);

            // output rich text view with dashed border
            // it is not necessary to chain decorators
            // we could we it separately
            dashedBorderedTextView.Draw();
        }
    }
}