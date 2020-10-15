using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Canonical
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void Primitive1()
        {
            Console.WriteLine("Calling Primitive1");
        }

        protected override void Primitive2()
        {
            Console.WriteLine("Calling Primitive2");
        }

        protected override bool Primitive3()
        {
            return true;
        }
    }
}