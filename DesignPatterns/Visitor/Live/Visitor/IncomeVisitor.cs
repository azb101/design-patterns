using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            employee.Income *= 1.10;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name} new income is {employee.Income}");
        }
    }
}
