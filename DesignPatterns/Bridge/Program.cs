using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Canonical;
using Bridge.Common;
using Bridge.IOS;
using Bridge.Windows;

namespace Bridge
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // live example
            Window window = new XWindow();
            window.Draw();

            window = new IosWindow();
            window.Draw();

            Console.WriteLine();

            // canonical example
            var abstraction = new RefinedAbstraction();
            abstraction.Implementor = new ConcreateImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreateImplementorB();
            abstraction.Operation();
        }
    }
}