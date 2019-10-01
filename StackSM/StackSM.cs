using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSM
{
    public class StackSM
    {
        int[] elements;
        int top;
        int max;
        public StackSM(int size)
        {
            max = size;
            top = -1;
            elements = new int[size];
        }

        public void PushSM(int data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("The stack is full");
                return;
            }
            top = top + 1;
            elements[top] = data;
        }

        public int PopSM()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return int.MinValue;
            }
            int val = elements[top];
            top = top - 1;
            return val;
        }

        public int PeekSM()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return int.MinValue;
            }
            int val = elements[top];
            return val;
        }

        public void PrintStackSM()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
            }
            while (top != -1)
            {
                Console.WriteLine(elements[top]);
                top = top - 1;
            }
        }
    }
}
