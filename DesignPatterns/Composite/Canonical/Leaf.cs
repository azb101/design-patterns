using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Canonical
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }


        public override void Add(Component item)
        {
            Console.WriteLine("not applicable");
        }

        public override void Remove(Component item)
        {
            Console.WriteLine("not applicable");
        }


        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

    }
}
