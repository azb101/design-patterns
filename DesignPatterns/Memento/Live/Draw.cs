using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Live
{
    public class Draw
    {
        public string Name { get; set; }

        public void Visualize()
        {
            Console.WriteLine($"Drawing: {Name}");
        }
    }
}
