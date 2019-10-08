using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Insert a node in the circular linked list
            //CircularLinkedListSM circularLinkedList = new CircularLinkedListSM();
            //circularLinkedList.AddToEnd(3);
            //circularLinkedList.AddToEnd(4);
            //circularLinkedList.AddToEnd(5);
            //circularLinkedList.AddToEnd(6);
            //circularLinkedList.AddToEnd(7);
            //circularLinkedList.Print();



            ////Split a Circular Linked List into two halves
            CircularLinkedListSM circularLinkedList = new CircularLinkedListSM();
            circularLinkedList.AddToEnd(3);
            circularLinkedList.AddToEnd(4);
            circularLinkedList.AddToEnd(5);
            circularLinkedList.AddToEnd(6);
            circularLinkedList.AddToEnd(7);
            circularLinkedList.SplitItIntoTwoHalves();



            Console.ReadLine();

        }
    }
}
