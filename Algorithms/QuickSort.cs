using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class QuickSort
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 10, 40, 3, 4 };
            SortMe(a, 0, a.Length - 1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }

        private static void SortMe(int[] a, int l, int r)
        {
            if (l < r)
            {
                int partiton = Partition(a, l, r);
                SortMe(a, l, partiton - 1);
                SortMe(a, partiton + 1, r);
            }
           
        }

        private static int Partition(int[] a, int l, int r)
        {
            
                int i = l - 1;
                int key = a[r];
                for (int j = l; j < r; j++)
                {
                    if (a[j] < key)
                    {
                        i++;
                        swap(ref a[i], ref a[j]);
                    }
                }

            swap(ref a[i + 1], ref a[r]);
            
            return i + 1;
        }

        private static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
