using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Add Node at the start and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtFirstSM(1);
            //linkedListSM.AddNodeAtFirstSM(2);
            //linkedListSM.AddNodeAtFirstSM(3);
            //linkedListSM.AddNodeAtFirstSM(4);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////add node at the end and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();


            ////add node after a given node and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //LinkedListNodeSM node1 = linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////add node after a given node
            //linkedListSM.AddNodeAfterAGivenNodeSM(node1, 12);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////Delete a node with the given data
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////linkedListSM.DeleteNodeWithGivenDataSm(3);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////Delete a node at a given position
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.DeleteNodeAtAGivenPositionSm(2);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();


            ////Length of a linked list
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //Console.WriteLine(linkedListSM.LengthOfLinkedListSM());



            ////SwapNodesWithoutSwappingData
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.SwapNodesWithSwappingDataSM(1,2);
            //linkedListSM.PrintLinkedListSM();



            ////Reversing the linked list
            //// Time Complexity: O(n)
            ////Space Complexity: O(1)
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.ReverseLinkedListSM();
            //linkedListSM.PrintLinkedListSM();


            ////Reversing the linked list using Recursion
            //// Time Complexity: O(n)
            ////Space Complexity: O(1)
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //LinkedListNodeSM linkedListUsingRecursionSm = linkedListSM.ReverseLinkedListUsingRecursionSM(linkedListSM.head);
            //while (linkedListUsingRecursionSm != null)
            //{
            //    Console.WriteLine(linkedListUsingRecursionSm.Data);
            //    linkedListUsingRecursionSm = linkedListUsingRecursionSm.Next;
            //}



            ////Merge two sorted linked lists
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.AddNodeAtLastSM(6);
            //LinkedListSM linkedListSM2 = new LinkedListSM();
            //linkedListSM2.AddNodeAtLastSM(3);
            //linkedListSM2.AddNodeAtLastSM(5);
            //linkedListSM2.AddNodeAtLastSM(7);
            //linkedListSM2.AddNodeAtLastSM(8);
            //LinkedListNodeSM mergeTwoSortedLinkedList = linkedListSM.MergeTwoSortedLinkedListSm(linkedListSM,linkedListSM2);
            //while (mergeTwoSortedLinkedList != null)
            //{
            //    Console.WriteLine(mergeTwoSortedLinkedList.Data);
            //    mergeTwoSortedLinkedList = mergeTwoSortedLinkedList.Next;
            //}



            ////Merge two sorted linked lists using recursion
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.AddNodeAtLastSM(6);
            //LinkedListSM linkedListSM2 = new LinkedListSM();
            //linkedListSM2.AddNodeAtLastSM(3);
            //linkedListSM2.AddNodeAtLastSM(5);
            //linkedListSM2.AddNodeAtLastSM(7);
            //linkedListSM2.AddNodeAtLastSM(8);
            //LinkedListNodeSM mergeTwoSortedLinkedListUsingRecursion = linkedListSM.MergeTwoSortedLinkedListUsingRecursionSm(linkedListSM.head, linkedListSM2.head);
            //while (mergeTwoSortedLinkedListUsingRecursion != null)
            //{
            //    Console.WriteLine(mergeTwoSortedLinkedListUsingRecursion.Data);
            //    mergeTwoSortedLinkedListUsingRecursion = mergeTwoSortedLinkedListUsingRecursion.Next;
            //}



            ////Reverse a LinkedList in groups of given size
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.AddNodeAtLastSM(5);
            //linkedListSM.AddNodeAtLastSM(6);
            //linkedListSM.AddNodeAtLastSM(7);
            //linkedListSM.AddNodeAtLastSM(8);
            //int gpSize = 3;
            //LinkedListNodeSM node = linkedListSM.ReverseLinkedListInGroupsOfGivenSizeSm(linkedListSM.head, gpSize);
            //while (node != null)
            //{
            //    Console.WriteLine(node.Data);
            //    node = node.Next;
            //}

            ////Search an element in a Linked List
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //bool found = linkedListSM.FindNodeWithDataSm(3);
            //Console.WriteLine(found);



            ////Search an element in a Linked List recursively
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //bool found = linkedListSM.FindNodeWithDataRecursivelySm(5,linkedListSM.head);
            //Console.WriteLine(found);



            //Write a function to get Nth node in a Linked List
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //int found = linkedListSM.FindNthNodeInLinkedListSm(2);
            //Console.WriteLine(found);



            ////Write a function to get Nth node in a Linked List
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //int found = linkedListSM.FindNthNodeInLinkedListSm(2);
            //Console.WriteLine(found);



            ////Write a function to get Nth node in a Linked List
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //int found = linkedListSM.FindNthNodeInLinkedListRecursivelySm(2,linkedListSM.head);
            //Console.WriteLine(found);



            ////Detect and Remove Loop in a Linked List
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(50);
            //linkedListSM.AddNodeAtLastSM(20);
            //linkedListSM.AddNodeAtLastSM(15);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.AddNodeAtLastSM(10);
            //linkedListSM.head.Next.Next.Next.Next.Next = linkedListSM.head.Next.Next;
            //bool t = linkedListSM.DetectAndRemoveLoopSm(linkedListSM);
            //if (t == true)
            //{
            //    Console.WriteLine("Loop deteched and is removed");
            //    linkedListSM.PrintLinkedListSM();
            //}
            //else
            //{
            //    Console.WriteLine("No loop present");
            //}



            ////Add two numbers represented by linked lists
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.AddNodeAtLastSM(6);
            //LinkedListSM linkedListSM2 = new LinkedListSM();
            //linkedListSM2.AddNodeAtLastSM(3);
            //linkedListSM2.AddNodeAtLastSM(5);
            //linkedListSM2.AddNodeAtLastSM(7);
            //linkedListSM2.AddNodeAtLastSM(8);
            //LinkedListNodeSM result = linkedListSM.AddTwoLinkedListTogetherSM(linkedListSM, linkedListSM2);
            //while (result != null)
            //{
            //    Console.WriteLine(result.Data);
            //    result = result.Next;
            //}


            Console.ReadLine();
        }
    }
}
