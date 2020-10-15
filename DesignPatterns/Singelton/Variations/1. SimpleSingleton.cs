using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages: Simple, Lazy 
    // Disadvantage: InheritanceNotSafe, ThreadNotSafe, ReflectionNotSafe
    public class SimpleSingleton
    {
        private static SimpleSingleton instance;

        private SimpleSingleton()
        {

        }

        public static SimpleSingleton Instance ()
        {
            if(instance == null)
            {
                instance = new SimpleSingleton();
            }

            return instance;
        }
    }
}
