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

    public class TwoStackSM
    {
        int top1;
        int top2;
        int max;
        int[] elements;
        public TwoStackSM(int size)
        {
            max = size;
            top1 = -1;
            top2 = max;
            elements = new int[size];
        }

        public void Push1SM(int data)
        {
            if (top2 - top1 > 1)
            {
                top1++;
                elements[top1] = data;
            }
        }

        public void Push2SM(int data)
        {
            if (top2 - top1 > 1)
            {
                top2--;
                elements[top2] = data;
            }
        }

        public int Pop1SM()
        {
            if (top1  > -1)
            {
                return elements[top1--];
            }
            return int.MinValue;
        }

        public int Pop2SM()
        {
            if (top2 < max)
            {
                return elements[top2++];
            }
            return int.MinValue;
        }
        public void PrintStack1SM()
        {
            while (top2 - top1 > 0 && top1>-1)
            {
                Console.WriteLine(Pop1SM());
            }
        }


        public void PrintStack2SM()
        {
            while (top2 - top1 > 0 && top2 < max)
            {
                Console.WriteLine(Pop2SM());
            }
        }
    }
}
