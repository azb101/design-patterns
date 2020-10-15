using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Common;

namespace Bridge.Windows
{
    public class XWindowImplementor : WindowImplementor
    {
        public override void DrawWindow()
        {
            DrawBounds();
            DrawOutline();
            FillBackground();
        }

        public void DrawBounds()
        {
            Console.WriteLine("window draws bounds");
        }

        public void DrawOutline()
        {
            Console.WriteLine("window draws outline");
        }

        public void FillBackground()
        {
            Console.WriteLine("Window fills background");
        }
    }
}