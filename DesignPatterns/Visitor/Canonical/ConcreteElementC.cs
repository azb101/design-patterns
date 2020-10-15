using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Canonical
{
    public class ConcreteElementC : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElemenC(this);
        }
    }
}
