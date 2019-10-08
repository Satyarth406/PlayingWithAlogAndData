using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Add a node in the end
            //DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            //doublyLinkedListSM.AddANodeInTheEnd(10);
            //doublyLinkedListSM.AddANodeInTheEnd(20);
            //doublyLinkedListSM.AddANodeInTheEnd(30);
            //doublyLinkedListSM.AddANodeInTheEnd(40);
            //doublyLinkedListSM.AddANodeInTheEnd(50);
            //doublyLinkedListSM.PrintDoublyLinkedList();



            ////Add a node after a given node
            //DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            //doublyLinkedListSM.AddANodeInTheEnd(10);
            //doublyLinkedListSM.AddANodeInTheEnd(20);
            //doublyLinkedListSM.AddANodeInTheEnd(30);
            //doublyLinkedListSM.AddANodeInTheEnd(40);
            //doublyLinkedListSM.AddANodeInTheEnd(50);
            //doublyLinkedListSM.AddANodeAfterAGivenData(30, 33);
            //doublyLinkedListSM.PrintDoublyLinkedList();



            ////Delete a node in a Doubly Linked List
            DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            doublyLinkedListSM.AddANodeInTheEnd(10);
            doublyLinkedListSM.AddANodeInTheEnd(20);
            doublyLinkedListSM.AddANodeInTheEnd(30);
            doublyLinkedListSM.AddANodeInTheEnd(40);
            doublyLinkedListSM.AddANodeInTheEnd(50);
            doublyLinkedListSM.DeleteANode(30);
            doublyLinkedListSM.PrintDoublyLinkedList();



            Console.ReadLine();
        }
    }
}
