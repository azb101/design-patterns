using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Canonical
{
    public abstract class Subject
    {
        protected List<string> state = new List<string>();
        private List<Observer> observers = new List<Observer>();

        public virtual void Attach(Observer observer)
        {
            if (observer != null)
                observers.Add(observer);
        }

        public virtual void Detach(int id)
        {
            int i = 0;
            foreach (var item in observers)
            {
                if (item.Id == id)
                {
                    break;
                }

                i++;
            }

            observers.RemoveAt(i);
        }

        public virtual void SetState(List<string> newState)
        {
            this.state.Clear();
            this.state.AddRange(newState);
            NotifyAll();
        }

        protected void NotifyAll()
        {
            foreach (var observer in observers)
            {
                observer.UpdateState(this.state);
            }
        }
    }
}