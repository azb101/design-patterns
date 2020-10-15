using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Canonical
{
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(int id)
        {
            this.Id = id;
        }
    }
}