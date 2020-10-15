using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Canonical
{
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElemenC(ConcreteElementC element)
        {
            Console.WriteLine("VisitConcreteElemenC by 2");
        }

        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine("VisitConcreteElementA by 2");
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine("VisitConcreteElementB by 2");
        }
    }
}
