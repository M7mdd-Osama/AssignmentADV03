using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //public delegate TResult CompareFuncDelegate<in T, out TResult>(T A, T B);
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] array, Func<T, T, bool> compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (compareFunc(array[j], array[j + 1]))
                            SWAP(ref array[j], ref array[j + 1]);
            }
        }
        public static void SWAP(ref T arr1, ref T arr2)
        {
            T Temp = arr1;
            arr1 = arr2;
            arr2 = Temp;
        }
    }
}