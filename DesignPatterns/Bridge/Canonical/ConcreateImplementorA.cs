﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Canonical
{
    public class ConcreateImplementorA : Implementor
    {
        public override void DoSomething()
        {
            Console.WriteLine("DoSomething: A");
        }
    }
}