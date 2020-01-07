using System;

namespace Algorithms
{
    class MergeSort
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 10, 4, 3, 40 };
            SortMe(a, 0, a.Length-1);
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
                int m = (l + r) / 2;
                SortMe(a, l, m);
                SortMe(a, m + 1, r);
                Merge(a, l, m, r);
            }

        }

        private static void Merge(int[] a, int l, int m, int r)
        {
            int[] temp = new int[r - l + 1];
            int n1 = m + 1;
            int n2 = 0;
            int n3 = l;
            while (l <= m && n1 <= r)
            {
                if (a[l] < a[n1])
                {
                    temp[n2++] = a[l++];
                }
                else
                {
                    temp[n2++] = a[n1++];
                }
            }
            while (l <= m)
            {
                temp[n2++] = a[l++];
            }
            while (n1 <= r)
            {
                temp[n2++] = a[n1++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                a[n3 + i] = temp[i];
            }
        }
    }
}
