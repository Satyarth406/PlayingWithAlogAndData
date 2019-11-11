using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySm
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Search, insert and delete in an unsorted array
            //int[] arr = { 11, 12, 5, 30, 61, 80 };
            //int searchEle = 30;
            //int indexOfEle = FindElement(arr, searchEle);



            ////Largest Sum Contiguous Subarray
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int sum = FindLargestSumContiguous(a);

        }

        private static int FindLargestSumContiguous(int[] a)
        {
            int maxSum = a[0];
            int maxTillNow = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                maxTillNow = Math.Max(a[i], maxSum + a[i]);
                if (maxTillNow > maxSum) maxSum = maxTillNow;
            }
            return maxSum;
        }

        private static int FindElement(int[] arr, int searchEle)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchEle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
