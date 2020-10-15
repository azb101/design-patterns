using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Canonical
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Primitive1();
            if (Primitive3())
                Primitive2();
        }

        protected abstract void Primitive1();

        protected abstract void Primitive2();

        protected abstract bool Primitive3();
    }
}