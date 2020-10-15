using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Canonical;
using Strategy.Live;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical

            var context = new Context(new ConcreteStrategyA());
            context.AlgorithmInterface();

            context = new Context(new ConcreteStrategyB());
            context.AlgorithmInterface();

            // live
            var sortList = new SortList();
            sortList.Add(10);
            sortList.Add(2);
            sortList.Add(4);
            sortList.Add(5);
            sortList.Add(1);

            sortList.SetStrategy(new BubbleSortStrategy());
            sortList.SetStrategy(new QuickSortStrategy());

            sortList.Sort();
        }
    }
}