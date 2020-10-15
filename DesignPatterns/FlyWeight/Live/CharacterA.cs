using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Live
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = 'A';
            width = 100;
            height = 100;
            transparency = 5;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("display character a at point:" + pointSize);
        }
    }
}
