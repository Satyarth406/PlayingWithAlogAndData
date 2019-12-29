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

            #region Search, insert and delete in an unsorted array

            //int[] arr = { 11, 12, 5, 30, 61, 80 };
            //int searchEle = 30;
            //int indexOfEle = FindElement(arr, searchEle);

            #endregion


            #region Given an array A[] and a number x, check for pair in A[] with sum as x Q(nlog n)

            //int[] a = { 1, 4, 45, 6, 10, -8 };
            //int sum = int.Parse(Console.ReadLine());
            //Array.Sort(a);
            //bool checkForSum = CheckForGivenSum(a, sum);
            //Console.WriteLine(checkForSum);

            #endregion


            #region Given an array A[] and a number x, check for pair in A[] with sum as x Q(n)

            //int[] a = { 1, 4, 45, 6, 10, -8 };
            //int sum = int.Parse(Console.ReadLine());
            //Array.Sort(a);
            //bool checkForSum = CheckForGivenSumFaster(a, sum);
            //Console.WriteLine(checkForSum);

            #endregion


            #region Find common elements in three sorted arrays

            //int[] ar1 = { 1, 5, 10, 20, 40, 80 };
            //int[] ar2 = { 6, 7, 20, 80, 100 };
            //int[] ar3 = { 3, 4, 15, 20, 30, 70, 80, 120 };
            //FindCommonElements(ar1, ar2, ar3);

            #endregion


            #region Find all triplets with zero sum

            //int[] arr = { 0, -1, 2, -3, 1 };
            //FindTripletsWithZeroSum(arr);

            #endregion


            #region Program for array rotation Q(n*d) d no. of rotations

            //int[] arr = { 1, 2, 3, 4, 5 };
            //LeftRotateArray(arr, 2);

            #endregion


            #region Program for array rotation Q(n) space Q(d) d no. of rotations

            int[] arr = { 1, 2, 3, 4, 5 };
            LeftRotateArrayFaster(arr, 2);

            #endregion


            ////Largest Sum Contiguous Subarray
            //int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            //int sum = FindLargestSumContiguous(a);


            Console.ReadLine();

        }

        private static void LeftRotateArrayFaster(int[] arr, int v)
        {
            int[] temp = new int[v];
            for (int i = 0; i < v; i++)
            {
                temp[i] = arr[i];
            }

            for (int i = 0; i < arr.Length - v ; i++)
            {
                 arr[i]= arr[i + v];
            }
            int l = 0;
            for (int i = arr.Length-v; i < arr.Length; i++)
            {
                arr[i] = temp[l++];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }

        private static void LeftRotateArray(int[] arr, int v)
        {
            for (int i = 0; i < v; i++)
            {
                RotateByOne(arr);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void RotateByOne(int[] arr)
        {
            int start = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                 arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = start;
        }

        private static void FindTripletsWithZeroSum(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int start = 0;
                int end = arr.Length - 2 - i;
                while (start < end)
                {
                    if (arr[arr.Length - i - 1] + arr[start] + arr[end] == 0)
                    {
                        Console.WriteLine($"{arr[arr.Length - i - 1]} {arr[start]}  {arr[end]}");

                        start++;
                        end--;
                    }
                    else if (arr[i] + arr[start] + arr[end] < 0)
                    {
                        start++;
                    }
                    else if (arr[i] + arr[start] + arr[end] > 0)
                    {
                        end--;
                    }
                }
            }
        }

        private static void FindCommonElements(int[] ar1, int[] ar2, int[] ar3)
        {
            int i = 0, j = 0, k = 0;
            List<int> li = new List<int>();
            while (i < ar1.Length && j < ar2.Length && k < ar3.Length)
            {
                if (ar1[i] == ar2[j] && ar1[k] == ar2[j])
                {
                    li.Add(ar1[i]);
                    i++;
                    j++;
                    k++;
                }
                else if (ar1[i] < ar2[j])
                {
                    i++;
                }
                else if (ar1[k] > ar2[j])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }

        private static bool CheckForGivenSumFaster(int[] a, int sum)
        {
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (hashset.Contains(a[i]))
                {
                    return true;
                }
                else
                {
                    hashset.Add(sum - a[i]);
                }
            }
            return false;
        }

        private static bool CheckForGivenSum(int[] a, int sum)
        {
            int start = 0;
            int end = a.Length - 1;
            while (start < end)
            {
                if (a[start] + a[end] == sum)
                {
                    return true;
                }
                else if (a[start] + a[end] < sum)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return false;
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
