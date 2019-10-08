using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class CircularLinkedListSM
    {
        public CircularLinkedListNodeSM Head { get; set; }
        public CircularLinkedListNodeSM Last { get; set; }


        public void AddToEnd(int d)
        {
            CircularLinkedListNodeSM circularLinkedListNodeSM = new CircularLinkedListNodeSM(d);
            if (Head == null)
            {
                Head = circularLinkedListNodeSM;
                Head.Next = Head;
                Last = Head;
                return;
            }
            Last.Next = circularLinkedListNodeSM;
            circularLinkedListNodeSM.Next = Head;
            Last = circularLinkedListNodeSM;
        }

        public void Print()
        {
            CircularLinkedListNodeSM dummy = Head;

            if (dummy == null)
            {
                Console.WriteLine("No Data present");
                return;
            }
            do
            {
                Console.WriteLine(dummy.Data);
                dummy = dummy.Next;
            } while (dummy != Head);

        }

        public void SplitItIntoTwoHalves()
        {
            CircularLinkedListNodeSM dummy = Head;
            CircularLinkedListNodeSM secondHalf;

            CircularLinkedListNodeSM firstHalf;

            if (Head == null)
            {
                Console.WriteLine("No data present to be split");
                return;
            }
            int nodeCount = 0;
            do
            {
                nodeCount++;
                dummy = dummy.Next;
            } while (dummy != Head);
            dummy = Head;
            int count = (int)Math.Ceiling(nodeCount / 2.0);
            while (count-- > 1)
            {
                dummy = dummy.Next;
            }
            secondHalf = dummy.Next;
            firstHalf = Head;
            dummy.Next = firstHalf;
            Last.Next = secondHalf;
            Print(firstHalf);
            Console.WriteLine();
            Print(secondHalf);


        }

        public void Print(CircularLinkedListNodeSM firstHalf)
        {
            CircularLinkedListNodeSM dummy = firstHalf;

            if (dummy == null)
            {
                Console.WriteLine("No Data present");
                return;
            }
            do
            {
                Console.WriteLine(dummy.Data);
                dummy = dummy.Next;
            } while (dummy != firstHalf);
        }

        public void AddAtStart(int d)
        {
            CircularLinkedListNodeSM circularLinkedListNodeSM = new CircularLinkedListNodeSM(d);
            if (Head == null)
            {
                Head = circularLinkedListNodeSM;
                Head.Next = Head;
                Last = Head;
                return;
            }
            Last.Next = circularLinkedListNodeSM;
            circularLinkedListNodeSM.Next = Head;
            Head = circularLinkedListNodeSM;
        }
    }

    public class CircularLinkedListNodeSM
    {
        public int Data { get; set; }
        public CircularLinkedListNodeSM Next { get; set; }
        public CircularLinkedListNodeSM(int d)
        {
            Data = d;
        }
    }
}
