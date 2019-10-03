using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InsertionSort
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 10, 4, 3, 40 };
            SortMe(a);
            Console.ReadLine();
        }

        private static void SortMe(int[] a)
        {
            int s = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                int j = i - 1;
                while(j>=0 && a[j] > a[j+1])
                {
                    swap(ref a[j], ref a[j+1]);
                    j--;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
