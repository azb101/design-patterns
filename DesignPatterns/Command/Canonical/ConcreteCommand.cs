﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Canonical
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(IReceiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Run();
        }
    }
}