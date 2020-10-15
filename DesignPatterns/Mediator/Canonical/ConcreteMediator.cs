using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Canonical
{
    class ConcreteMediator : Mediator
    {
        public Colleague Colleague1 { get; set; }
        public Colleague Colleague2 { get; set; }

        public override void Send(string message, Colleague collegue)
        {
            if (collegue == Colleague1)
                Colleague2.Notify(message);
            else
                Colleague1.Notify(message);
        }
    }
}
