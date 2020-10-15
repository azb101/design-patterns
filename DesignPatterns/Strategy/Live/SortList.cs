using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Live
{
    public class SortList
    {
        private List<int> list;
        private SortStrategy strategy;

        public SortList()
        {
            this.list = new List<int>();
        }

        public void SetStrategy(SortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Add(int item)
        {
            list.Add(item);
        }

        public virtual void Sort()
        {
            if (strategy == null)
            {
                Console.WriteLine("No strategy setup");
                return;
            }

            strategy.Sort(list);

            Console.WriteLine(string.Join(" ", list));
        }
    }
}