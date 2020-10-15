using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Live
{
    public class DrawMemento
    {
        public List<Draw> archivedItems { get; set; }

        public DrawMemento(List<Draw> items)
        {
            this.archivedItems = items;
        }
    }
}
