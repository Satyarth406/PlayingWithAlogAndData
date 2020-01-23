using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapDsSm
{
    public class HeapSm
    {
        private int[] a;
        private int size;
        int capacity;
        public HeapSm(int size)
        {
            this.capacity = size;
            a = new int[capacity];
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }
        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public int Right(int i)
        {
            return 2 * i + 2;
        }
        public void InsertKey(int key)
        {
            if (capacity == size)
            {
                Console.WriteLine("heap is full");
                return;
            }
            size++;
            int i = size - 1;
            a[size - 1] = key;
            while (i > 0 && a[Parent(i)] > a[i])
            {
                swap(ref a[Parent(i)], ref a[i]);
                i = Parent(i);
            }
        }


        public void DeleteKey(int i)
        {
            DecreaseKey(i, int.MinValue);
            ExtractMin();
        }

        public int ExtractMin()
        {
            if (size <= 0) return int.MinValue;
            if (size == 1)
            {
                size--;
                return a[0];
            }

            int root = a[0];
            a[0] = a[size - 1];
            size--;
            MinHeapify(0);
            return root;
        }

        private void MinHeapify(int rootKey)
        {
            int smallest = rootKey;
            int left = Left(rootKey);
            int right = Right(rootKey);
            if (left < size && a[smallest] > a[left])
            {
                smallest = Left(rootKey);
            }
            if (right < size && a[smallest] > a[right])
            {
                smallest = right;
            }
            if (smallest != rootKey)
            {
                swap(ref a[smallest], ref a[rootKey]);
                MinHeapify(smallest);
            }

        }


        private void MinHeapify(int[] ar, int n, int rootKey)
        {
            int smallest = rootKey;
            int left = Left(rootKey);
            int right = Right(rootKey);
            if (left < n && ar[smallest] > ar[left])
            {
                smallest = Left(rootKey);
            }
            if (right < n && ar[smallest] > ar[right])
            {
                smallest = right;
            }
            if (smallest != rootKey)
            {
                swap(ref ar[smallest], ref ar[rootKey]);
                MinHeapify(ar,n,smallest);
            }

        }

        public void DecreaseKey(int i, int key)
        {
            a[i] = key;
            while (i > 0 && a[Parent(i)] > a[i])
            {
                swap(ref a[Parent(i)], ref a[i]);
                i = Parent(i);
            }
        }

        private void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }



        public void HeapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                MinHeapify(arr, n, i);

            }
            for (int i = n-1; i >=0 ; i--)
            {
                int temp = a[i];
                a[i] = a[0];
                a[0] = temp;
                
                MinHeapify(arr,0,i);
            }
        }
    }
}
