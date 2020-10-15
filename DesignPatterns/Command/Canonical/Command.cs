using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Canonical
{
    public abstract class Command
    {
        protected IReceiver receiver;

        public abstract void Execute();

        public Command(IReceiver receiver)
        {
            this.receiver = receiver;
        }
    }
}