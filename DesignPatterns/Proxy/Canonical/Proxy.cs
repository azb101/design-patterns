using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Canonical
{
    public class Proxy : Subject
    {
        private RealSubject subject;

        public Proxy()
        {
            Console.WriteLine("Proxy created");
        }

        public override void Request()
        {
            if (subject == null)
                subject = new RealSubject();

            subject.Request();
        }
    }
}
