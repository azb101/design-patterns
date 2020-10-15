using Memento.Canonical;
using Memento.Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical
            var originator = new Originator();
            originator.State = "ON";

            var caretaker = new Caretaker();
            caretaker.memento = originator.CreateMemento();

            originator.State = "OFF";
            originator.SetMemento(caretaker.memento);
            Console.WriteLine();


            // live
            var paint = new GraphicProcessor();
            paint.DrawNewFigure(new Draw { Name = "line1" });
            paint.DrawNewFigure(new Draw { Name = "line2" });
            paint.DrawNewFigure(new Draw { Name = "triangleA" });

            var mem = new SwapMemmory();
            mem.memento = paint.CreateMemento();

            paint.DrawNewFigure(new Draw { Name = "line5" });

            paint.SetMemento(mem.memento);
        }
    }
}
