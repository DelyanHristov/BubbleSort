using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Sort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int q = 0; q < a.Length - 1; q++)
                {

                    if (Less(a[q], a[q + 1]))
                    {
                        Swap(a, q, q + 1);
                    }

                }
            }
        }
        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) > 0;
        }
        static void Swap<T>(T[] collection, int from, int to)
        {
            T a = collection[from];
            collection[from] = collection[to];
            collection[to] = a;



        }




    }
}
