using System;

namespace StackSM
{
    public class StackSM
    {
        readonly int[] _elements;
        int _top;
        readonly int _max;
        public StackSM(int size)
        {
            _max = size;
            _top = -1;
            _elements = new int[size];
        }

        public void PushSm(int data)
        {
            if (_top == _max - 1)
            {
                Console.WriteLine("The stack is full");
                return;
            }
            _top = _top + 1;
            _elements[_top] = data;
        }

        public int PopSm()
        {
            if (_top == -1)
            {
                return int.MinValue;
            }
            int val = _elements[_top];
            _top = _top - 1;
            return val;
        }

        public int PeekSm()
        {
            if (_top == -1)
            {
                return int.MinValue;
            }
            int val = _elements[_top];
            return val;
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public void PrintStackSm()
        {
            if (_top == -1)
            {
                Console.WriteLine("The stack is empty");
            }
            while (_top != -1)
            {
                Console.WriteLine(_elements[_top]);
                _top = _top - 1;
            }
        }

        public void ReverseAStackUsingRecursionSm()
        {
            if (PeekSm() == int.MinValue) return;
            int t = PopSm();
            ReverseAStackUsingRecursionSm();
            InsertAtBottomOfStackSm(t);
        }

        private void InsertAtBottomOfStackSm(int t)
        {
            if (PeekSm() == int.MinValue)
            {
                PushSm(t);
                return;
            }
            int z = PopSm();
            InsertAtBottomOfStackSm(t);
            PushSm(z);
        }

        public void SortAStackUsingRecursionSm()
        {
            if (PeekSm() == int.MinValue) return;
            int t = PopSm();
            SortAStackUsingRecursionSm();
            InsertSortedInTheStackSm(t);
        }

        private void InsertSortedInTheStackSm(int t)
        {
            if (PeekSm() == int.MinValue)
            {
                PushSm(t);
                return;
            }
            if (PeekSm() < t)
            {
                PushSm(t);
                return;
            }
            int z = PopSm();
            InsertSortedInTheStackSm(t);
            PushSm(z);
        }

        internal StackSM SortUsingTemp()
        {
            StackSM temp = new StackSM(_max);
            while (!IsEmpty())
            {
                int t = PopSm();
                if (temp.IsEmpty())
                {
                    temp.PushSm(t);
                    continue;
                }
                while (!temp.IsEmpty() && temp.PeekSm() < t)
                {
                    PushSm(temp.PopSm());
                }
                temp.PushSm(t);
            }
            return temp;
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
            if (top1 > -1)
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
            while (top2 - top1 > 0 && top1 > -1)
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

    public class StackNode
    {
        public int Data;
        public StackNode Next;
        public StackNode Prev;

        public StackNode(int d)
        {
            Data = d;
            Next = null;
            Prev = null;
        }
    }
}
