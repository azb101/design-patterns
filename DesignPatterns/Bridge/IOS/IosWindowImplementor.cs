using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Common;

namespace Bridge.IOS
{
    public class IosWindowImplementor : WindowImplementor
    {
        public override void DrawWindow()
        {
            this.DrawBorders();
            this.DrawBackground();
        }

        private void DrawBorders()
        {
            Console.WriteLine("ios draws borders");
        }

        private void DrawBackground()
        {
            Console.WriteLine("ios draws background");
        }
    }
}