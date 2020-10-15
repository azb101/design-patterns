using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Canonical;
using TemplateMethod.Live;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical
            Console.WriteLine("concrete class A");
            var a = new ConcreteClassA();
            a.TemplateMethod();

            Console.WriteLine("concrete class B");
            var b = new ConcreteClassB();
            b.TemplateMethod();

            // live
            Console.WriteLine();
            var dao = new Products("connection string");
            dao.Run();
        }
    }
}