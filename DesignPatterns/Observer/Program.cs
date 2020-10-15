using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Canonical;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical example

            var subject = new ConcreteSubject();

            var observer1 = new ConcreteObserver(1);
            var observer2 = new ConcreteObserver(2);

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.SetState(new List<string>());
            subject.UpdateStatePartially("yoyo");
            subject.UpdateStatePartially("ahahha");
        }
    }
}