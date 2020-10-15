using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Canonical
{
    public class ConcreteSubject : Subject
    {
        public virtual void UpdateStatePartially(string str)
        {
            this.state.Add(str);
            NotifyAll();
        }
    }
}