using System;
using System.Collections.Generic;

namespace Strategy.Live
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<int> list);
    }
}