using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    /// <summary>
    //https://www.geeksforgeeks.org/linked-list-set-1-introduction/
    /// </summary>
    public class LinkedListSM
    {
        public LinkedListNodeSM head;
        public LinkedListNodeSM last;
        public LinkedListSM()
        {
            head = null;
            last = null;
        }

        
        /// <summary>
        /// returns the created node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public LinkedListNodeSM AddNodeAtFirstSM(int data)
        {
            if (head == null)
            {
                head = new LinkedListNodeSM(data);
                last = head;
                return head;
            }
            LinkedListNodeSM n = new LinkedListNodeSM(data);
            n.Next = head;
            head = n;
            return n;
        }

        public LinkedListNodeSM AddNodeAtLastSM(int data)
        {
            if (head == null)
            {
                head = new LinkedListNodeSM(data);
                last = head;
                return head;
            }
            LinkedListNodeSM n = new LinkedListNodeSM(data);
            last.Next = n;
            last = n;
            return n;
        }

        public void DeleNodeWithGivenData(int data)
        {
            LinkedListNodeSM dummy = head;
            LinkedListNodeSM dummyBefore = head; //node before the node to be deleted.

            if (dummy == null)
            {
                Console.WriteLine("There are no items in the linked list");
                return;
            }

            if(dummy.Data == data)
            {
                head = head.Next;
                return;
            }

            while(dummy!=null && dummy.Data != data)
            {
                dummyBefore = dummy;
                dummy = dummy.Next;
            }
            if (dummy == null)
            {
                Console.WriteLine("The given item is not present");
                return;
            }
            dummyBefore.Next = dummy.Next;
            
        }

        public void DeleNodeAtAGivenData(int data)
        {
            LinkedListNodeSM dummy = head;
            LinkedListNodeSM dummyBefore = head; //node before the node to be deleted.

            if (dummy == null)
            {
                Console.WriteLine("There are no items in the linked list");
                return;
            }

            if (dummy.Data == data)
            {
                head = head.Next;
                return;
            }

            while (dummy != null && dummy.Data != data)
            {
                dummyBefore = dummy;
                dummy = dummy.Next;
            }
            if (dummy == null)
            {
                Console.WriteLine("The given item is not present");
                return;
            }
            dummyBefore.Next = dummy.Next;

        }


        public void AddNodeAfterAGivenNodeSM(LinkedListNodeSM nodeToInsertAfter, int dataToInsert)
        {
            LinkedListNodeSM newNode = new LinkedListNodeSM(dataToInsert);
            newNode.Next = nodeToInsertAfter.Next;
            nodeToInsertAfter.Next = newNode;
        }

        public void PrintLinkedListSM()
        {
            if (head == null)
            {
                Console.WriteLine("No items in the linked list");
                return;
            }
            LinkedListNodeSM nodeIterator = head;
            while (nodeIterator != null)
            {
                Console.WriteLine(nodeIterator.Data);
                nodeIterator = nodeIterator.Next;
            }
        }
    }
    public class LinkedListNodeSM
    {
        public int Data { get; set; }
        public LinkedListNodeSM Next { get; set; }
        public LinkedListNodeSM(int d)
        {
            Data = d;
            Next = null;
        }
    }

}
