using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ImaginaryExample
{
    public class Traveller
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
}