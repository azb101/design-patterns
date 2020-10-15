using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Canonical
{
    public class Abstraction
    {
        protected Implementor impl;

        public Implementor Implementor
        {
            get
            {
                return impl;
            }
            set
            {
                impl = value;
            }
        }

        public virtual void Operation()
        {
            impl.DoSomething();
        }
    }
}