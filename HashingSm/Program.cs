using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingSm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Given an array A[] and a number x, check for pair in A[] with sum as x

            int[] arr = { 1, 4, 45, 6, 10, -8 };
            int s = 16;
            FindPairWithGivenSumSm(arr, s);
            Console.ReadLine();

            #endregion
        }

        private static void FindPairWithGivenSumSm(int[] arr, int s)
        {
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashset.Contains(s - arr[i]))
                {
                    Console.WriteLine($"the pair is {arr[i]} and {s-arr[i]}");
                }
                hashset.Add(arr[i]);
            }
        }
    }
}
