using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live
{
    public class Director : Employee
    {
        public Director(string name) : base(name, 100000, 26)
        {
        }
    }
}
