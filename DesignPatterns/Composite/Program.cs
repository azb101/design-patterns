using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Canonical;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var com = new Composite.Canonical.Composite("root");
            com.Add(new Leaf("leave1"));
            com.Add(new Leaf("leave2"));

            var composite2 = new Composite.Canonical.Composite("complex sub node");
            composite2.Add(new Leaf("leave3"));

            com.Add(composite2);

            com.Display(1);
        }
    }
}
