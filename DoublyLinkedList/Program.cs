using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Add a node in the end
            //DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            //doublyLinkedListSM.AddANodeInTheEndSm(10);
            //doublyLinkedListSM.AddANodeInTheEndSm(20);
            //doublyLinkedListSM.AddANodeInTheEndSm(30);
            //doublyLinkedListSM.AddANodeInTheEndSm(40);
            //doublyLinkedListSM.AddANodeInTheEndSm(50);
            //doublyLinkedListSM.PrintDoublyLinkedListSm();



            ////Add a node after a given node
            //DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            //doublyLinkedListSM.AddANodeInTheEndSm(10);
            //doublyLinkedListSM.AddANodeInTheEndSm(20);
            //doublyLinkedListSM.AddANodeInTheEndSm(30);
            //doublyLinkedListSM.AddANodeInTheEndSm(40);
            //doublyLinkedListSM.AddANodeInTheEndSm(50);
            //doublyLinkedListSM.AddANodeAfterAGivenData(30, 33);
            //doublyLinkedListSM.PrintDoublyLinkedListSm();



            ////Delete a node in a Doubly Linked List
            //DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            //doublyLinkedListSM.AddANodeInTheEndSm(10);
            //doublyLinkedListSM.AddANodeInTheEndSm(20);
            //doublyLinkedListSM.AddANodeInTheEndSm(30);
            //doublyLinkedListSM.AddANodeInTheEndSm(40);
            //doublyLinkedListSM.AddANodeInTheEndSm(50);
            //doublyLinkedListSM.DeleteANodeSm(30);
            //doublyLinkedListSM.PrintDoublyLinkedListSm();



            ////Reverse a Doubly Linked List
            DoublyLinkedListSM doublyLinkedListSM = new DoublyLinkedListSM();
            doublyLinkedListSM.AddANodeInTheEndSm(10);
            doublyLinkedListSM.AddANodeInTheEndSm(20);
            doublyLinkedListSM.AddANodeInTheEndSm(30);
            doublyLinkedListSM.AddANodeInTheEndSm(40);
            doublyLinkedListSM.AddANodeInTheEndSm(50);
            DoublyLinkedListNodeSM node = doublyLinkedListSM.ReverseTheDoublyLinkedListSm();
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }

            Console.ReadLine();
        }
    }
}
