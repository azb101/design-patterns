using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Canonical
{
    public class Originator
    {
        private string state;

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
                Console.WriteLine($"State: {state}");
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("...................Restoring state.............. ");
            this.State = memento.State;
        }
    }
}
