using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Canonical
{
    public abstract class Observer
    {
        public int Id { get; set; }
        public List<string> state = new List<string>();

        public virtual void UpdateState(List<string> newState)
        {
            this.state.Clear();
            this.state.AddRange(newState);

            Console.WriteLine($"Observer#{Id} has state: [{string.Join(" ", this.state)}]");
        }
    }
}