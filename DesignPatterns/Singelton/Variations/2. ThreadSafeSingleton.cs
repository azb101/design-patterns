using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages: Simple, ThreadSafe
    // Disadvantage: NotLazy, InheritanceNotSafe, ReflectionNotSafe
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = new ThreadSafeSingleton();

        private ThreadSafeSingleton() { }
        
        public static ThreadSafeSingleton Instance ()
        {
            return instance;
        }
    }
}
