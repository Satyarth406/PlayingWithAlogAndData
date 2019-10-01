using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new stack and populating it
            StackSM stackSM = new StackSM(5);
            stackSM.PushSM(1);
            stackSM.PushSM(2);
            stackSM.PushSM(3);
            stackSM.PushSM(4);
            stackSM.PushSM(5);
            stackSM.PrintStackSM();

            Console.ReadLine();



        }
    }
}
