using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live 
{
    public class Clerk : Employee
    {
        public Clerk(string name) : base(name, 25000, 16)
        {

        }
    }
}
