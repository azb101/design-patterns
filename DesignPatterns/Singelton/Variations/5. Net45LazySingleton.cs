using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages:  ThreadSafe, Lazy, InheritanceSafe
        // Implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode for the Lazy<Singleton>.
    // Disadvantage:  ReflectionNotSafe
    public sealed class Net45LazySingleton
    {
        private static readonly Lazy<Net45LazySingleton> lazy = 
            new Lazy<Net45LazySingleton>(() => new Net45LazySingleton());
        
        public static Net45LazySingleton Instance { get { return lazy.Value; } }

        private Net45LazySingleton()
        {

        }
    }
}
