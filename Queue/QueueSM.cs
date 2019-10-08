using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueSM
    {
        private int[] queueElements;
        private int max;
        private int front;
        private int rear;

        public QueueSM(int size)
        {
            queueElements = new int[size];
            max = size;
            front = 0;
            rear = -1;
        }

        public void EnqueueSM(int d)
        {
            if(rear == max - 1)
            {
                Console.WriteLine("queue is full");
                return;
            }
            queueElements[++rear] = d;
        }

        public int DequeueSM()
        {
            if (front == rear+1)
            {
                Console.WriteLine("queue is empty");
                return int.MinValue;
            }
            int element = queueElements[front];
            front++;
            return element;
        }

        public void PrintQueueSM()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while(front!=rear+1)
            Console.WriteLine(queueElements[front++]);
        }
    }
}
