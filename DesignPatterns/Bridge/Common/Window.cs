using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Common
{
    public abstract class Window
    {
        protected WindowImplementor implementation;

        public abstract void Draw();
    }
}