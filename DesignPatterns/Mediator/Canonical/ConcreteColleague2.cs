using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Canonical
{
    class ConcreteColleague2 : Colleague
    {

        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {

        }
        public override void Notify(string message)
        {
            Console.WriteLine("Other collegue send: " + message);
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
