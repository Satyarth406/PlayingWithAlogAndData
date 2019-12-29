using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BubbleSort
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 10, 4, 3, 40 };
            SortMe(a);
            Console.ReadLine();
        }

        private static void SortMe(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-i-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                    }
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
