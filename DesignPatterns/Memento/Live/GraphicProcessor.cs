using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Live
{
    public class GraphicProcessor
    {
        private List<Draw> actions { get; set; } = new List<Draw>();

        public DrawMemento CreateMemento()
        {
            return new DrawMemento(new List<Draw>(actions));
        }

        public void SetMemento(DrawMemento memento)
        {
            Console.WriteLine("Applying some previous state");
            this.actions = memento.archivedItems;
            Repaint();
        }


        public void DrawNewFigure(Draw draw)
        {
            this.actions.Add(draw);
            Repaint();
        }


        private void Repaint()
        {
            Console.WriteLine("Repainting: ............................");
            foreach (var item in actions)
            {
                item.Visualize();
            }
            Console.WriteLine();
        }
    }
}
