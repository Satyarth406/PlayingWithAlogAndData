using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] a =  { 2, 3, 4, 10, 40 };
            int q = 40;
            int result = Search(a, 0, a.Length-1, q);
            if (result == -1)
            {
                Console.WriteLine("The given element is not present in the array");
                return;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //Remember this works only for the sorted array.
        private static int Search(int[] a,int start, int end, int ele)
        {
            if (start > end)
            {
                return -1;
            }
            int mid = start + (end-1) / 2;
            if (a[mid] == ele)
            {
                return mid;
            }
            else if(a[mid]>ele)
            {
                return Search(a, start, mid, ele);
            }
            return Search(a, mid, end, ele);

        }
    }
}
