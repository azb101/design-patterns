using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy.Canonical
{
    public class RealSubject : Subject
    {
        public RealSubject()
        {
            Thread.Sleep(500);
            Console.WriteLine("Real subject created");
        }

        public override void Request()
        {
            Console.WriteLine(" RealSubject.Request() ");
        }
    }
}
