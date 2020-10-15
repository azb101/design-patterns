using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Common;

namespace Bridge.Windows
{
    public class XWindow : Window
    {
        public XWindow()
        {
            implementation = new XWindowImplementor();
        }

        public override void Draw()
        {
            implementation.DrawWindow();
        }
    }
}