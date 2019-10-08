using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueSM queueSM = new QueueSM(5);
            queueSM.EnqueueSM(10);
            queueSM.EnqueueSM(20);
            queueSM.EnqueueSM(30);
            queueSM.EnqueueSM(40);
            queueSM.EnqueueSM(50);
            Console.WriteLine(queueSM.DequeueSM()); 
            queueSM.PrintQueueSM();

            Console.ReadLine();
        }
    }
}
