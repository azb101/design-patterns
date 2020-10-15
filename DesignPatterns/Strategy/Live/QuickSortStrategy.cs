using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Live
{
    internal class QuickSortStrategy : SortStrategy
    {
        public override void Sort(List<int> list)
        {
            Console.WriteLine("Sorting with quick sort");

            sort(list, 0, list.Count - 1);
        }

        private void sort(List<int> list, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = left + (right - left) / 2;

            if (i <= j)
            {
                while (list[i] < list[pivot]) i++;
                while (list[j] > list[pivot]) j--;

                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            if (i < right)
                sort(list, i, right);
            if (j > left)
                sort(list, left, j);
        }
    }
}