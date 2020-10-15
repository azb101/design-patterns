using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Live
{
    public abstract class Character
    {
        // these props form intristic state
        protected char symbol;
        protected int width;
        protected int height;
        protected int transparency;
        

        // pointSize is extrinsic state
        public abstract void Display(int pointSize);
        
    }
}
