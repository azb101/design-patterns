using FlyWeight.Canonical;
using FlyWeight.Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            // canonical example
            int extrinsicState = 20;

            var factory = new FlyweightFactory();

            var fa = factory.GetFlyWeight("A");
            fa.Operation(extrinsicState--);

            var fb = factory.GetFlyWeight("B");
            fb.Operation(extrinsicState--);

            var unsh = new UnsharedConcreteFlyweight();
            unsh.Operation(extrinsicState--);

            Console.WriteLine();

            // live example
            var fact = new CharacterFactory();
            var cha = fact.GetCharacter('a');

            cha.Display(100);
        }
    }
}
