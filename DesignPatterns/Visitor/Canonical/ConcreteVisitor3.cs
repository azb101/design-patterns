using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Canonical
{
    public class ConcreteVisitor3 : Visitor
    {
        public override void VisitConcreteElemenC(ConcreteElementC element)
        {
            Console.WriteLine("VisitConcreteElemenC by 3");
        }

        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine("VisitConcreteElemenA by 3");
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine("VisitConcreteElemenB by 3");
        }
    }
}
