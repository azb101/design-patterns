using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages:  ThreadSafe, OverridingSafe, ReflectionSafe, InheritanceSafe
    // Disadvantage: NotPerformant(as it copies DoubleChecking due to lock)
    public sealed class ReflectionSafeSingleton
    {
        private static readonly object locker = new object();
        private static ReflectionSafeSingleton instance;

        private ReflectionSafeSingleton()
        {
            if (ReflectionSafeSingleton.instance != null)
            {
                throw new Exception("Attempt to create singleton using reflection!!!!");
            }
        }

        public ReflectionSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new ReflectionSafeSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
