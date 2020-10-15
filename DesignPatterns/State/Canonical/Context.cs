using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Canonical
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get
            {
                return state;
            }
            set
            {
                Console.WriteLine("Current state: " + state.GetType());
                state = value;
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}