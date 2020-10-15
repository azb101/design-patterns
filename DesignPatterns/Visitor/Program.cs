using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Canonical;
using Visitor.Live;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical
            var objectStructure = new ObjectStructure();

            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());
            objectStructure.Attach(new ConcreteElementC());

            objectStructure.Accept(new ConcreteVisitor1());
            objectStructure.Accept(new ConcreteVisitor2());

            // live
            Console.WriteLine();
            var staff = new Staff();
            staff.Attach(new Director("Azat"));
            staff.Attach(new Clerk("Joe"));
            staff.Attach(new Clerk("Ann"));

            for (int i = 0; i < 3; i++)
            {
                staff.Accept(new VacationVisitor());
            }
        }
    }
}
