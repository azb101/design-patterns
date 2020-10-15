using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages: ThreadSafe, Lazy
    // Disadvantages: NotPerformant*, InheritanceNotSafe, ReflectionNotSafe
    public class DoubleCheckingSingleton
    {
        private static readonly object locker = new object();
        private static DoubleCheckingSingleton instance;

        private DoubleCheckingSingleton()
        {
        }

        public DoubleCheckingSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckingSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
