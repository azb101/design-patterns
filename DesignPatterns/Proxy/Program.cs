using Proxy.Canonical;
using Proxy.Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical
            var subject = new RealSubject();
            subject.Request();

            var proxy = new Proxy.Canonical.Proxy();
            proxy.Request();

            // live
            Console.WriteLine();

            var image = new ProxyImage("C://temp.jpq");
            // will be loaded lazyly
            image.Display();

            // wont be loaded 2nd time
            image.Display();
        }
    }
}
