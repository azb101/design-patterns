using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.ImaginaryExample;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // academic example
            var client = new Client();
            client.Request(new Adapter(new Adaptee()));

            Console.WriteLine("\n");

            // imaginary but more helpful example:
            // - imagine you have a driver who tries cross the desert,
            // - he drives a car
            // - but at some places it is impossible to drive a car
            // - so he should drive a camel
            var traveler = new Traveller();
            traveler.Drive(new Car());
            traveler.Drive(new TransportAdapter(new Camel()));
        }
    }
}