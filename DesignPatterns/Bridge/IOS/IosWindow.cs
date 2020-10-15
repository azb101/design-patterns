using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Common;

namespace Bridge.IOS
{
    public class IosWindow : Window
    {
        public IosWindow()
        {
            implementation = new IosWindowImplementor();
        }

        public override void Draw()
        {
            implementation.DrawWindow();
        }
    }
}