using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapDsSm
{
    class Program
    {
        static void Main(string[] args)
        {
            //HeapSm heapSm = new HeapSm(11);
            //heapSm.InsertKey(3);
            //heapSm.InsertKey(2);
            //heapSm.DeleteKey(1);
            //heapSm.InsertKey(15);
            //heapSm.InsertKey(5);
            //heapSm.InsertKey(4);
            //heapSm.InsertKey(45);
            //Console.WriteLine(heapSm.ExtractMin());
            //heapSm.DecreaseKey(2, 1);


            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int n = arr.Length;

            HeapSm ob = new HeapSm(arr.Length);
            ob.HeapSort(arr);


            Console.Read();
        }
    }
}
