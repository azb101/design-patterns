using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Canonical
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }


        public override void Add(Component item)
        {
            children.Add(item);
        }

        public override void Remove(Component item)
        {
            children.Remove(item);
        }


        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.name);
            foreach (var child in children)
            {
                child.Display(depth + 1);
            }
        }

    }
}
