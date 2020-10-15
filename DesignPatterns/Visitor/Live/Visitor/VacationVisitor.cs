using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            employee.VacationDays -= 1;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name} {employee.VacationDays}");
        }
    }
}
