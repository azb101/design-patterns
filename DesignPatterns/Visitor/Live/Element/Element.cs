﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Live
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
