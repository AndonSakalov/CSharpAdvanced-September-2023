using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MergeSort
{
    public class Mergesort<T> where T : IComparable
    {
        private static T[] aux;
        public static void Sort(T[] arr)
        {

        }
        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if (arr[mid].CompareTo(arr[mid + 1]) < 0)
            {
                return;
            }

            for (int index = lo; index < hi; index++)
            {
                aux[index] = arr[index];
            }
            int j = mid + 1;
            int i = lo;
            for (int k = lo; k <= hi; k++)
            {
                if (true)
                {

                }
            }
        }
    }
}
