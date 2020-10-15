using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton.Variations
{
    // Advantages:    ThreadSafe, Lazy, InheritanceSafe
    // Disadvantage:  ReflectionNotSafe
    public sealed class BillPoughSingleton
    {
        private BillPoughSingleton() { }
        public static BillPoughSingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }


        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as BeforeFieldInit
            static Nested()
            {
            }

            internal static readonly BillPoughSingleton instance = new BillPoughSingleton();
        }
         
    }
}
