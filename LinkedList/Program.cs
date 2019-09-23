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
            ////linkedListSM.DeleNodeWithGivenData(3);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////Delete a node at a given position
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            //linkedListSM.DeleteNodeAtAGivenPosition(2);
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
            //LinkedListNodeSM mergeTwoSortedLinkedList = linkedListSM.MergeTwoSortedLinkedList(linkedListSM,linkedListSM2);
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
            //LinkedListNodeSM mergeTwoSortedLinkedListUsingRecursion = linkedListSM.MergeTwoSortedLinkedListUsingRecursion(linkedListSM.head, linkedListSM2.head);
            //while (mergeTwoSortedLinkedListUsingRecursion != null)
            //{
            //    Console.WriteLine(mergeTwoSortedLinkedListUsingRecursion.Data);
            //    mergeTwoSortedLinkedListUsingRecursion = mergeTwoSortedLinkedListUsingRecursion.Next;
            //}



            //Reverse a LinkedList in groups of given size
            LinkedListSM linkedListSM = new LinkedListSM();
            linkedListSM.AddNodeAtLastSM(1);
            linkedListSM.AddNodeAtLastSM(2);
            linkedListSM.AddNodeAtLastSM(3);
            linkedListSM.AddNodeAtLastSM(4);
            linkedListSM.AddNodeAtLastSM(5);
            linkedListSM.AddNodeAtLastSM(6);
            linkedListSM.AddNodeAtLastSM(7);
            linkedListSM.AddNodeAtLastSM(8);
            int gpSize = 3;
            LinkedListNodeSM node = linkedListSM.ReverseLinkedListInGroupsOfGivenSize(linkedListSM.head, gpSize);
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.ReadLine();
        }
    }
}
