using System;

namespace DoublyLinkedList
{
    public class DoublyLinkedListSM
    {
        public DoublyLinkedListNodeSM Head;
        public DoublyLinkedListNodeSM Last;

        public DoublyLinkedListSM()
        {
            Head = null;
            Last = null;
        }

        public void AddANodeInTheEndSm(int data)
        {
            DoublyLinkedListNodeSM doublyLinkedListNodeSM = new DoublyLinkedListNodeSM(data);
            if (Head == null)
            {
                Head = doublyLinkedListNodeSM;
                Last = doublyLinkedListNodeSM;
                return;
            }
            doublyLinkedListNodeSM.Prev = Last;
            Last.Next = doublyLinkedListNodeSM;
            Last = doublyLinkedListNodeSM;
        }

        public void AddANodeAtFirstSm(int data)
        {
            DoublyLinkedListNodeSM doublyLinkedListNodeSM = new DoublyLinkedListNodeSM(data);
            if (Head == null)
            {
                Head = doublyLinkedListNodeSM;
                Last = doublyLinkedListNodeSM;
                return;
            }
            doublyLinkedListNodeSM.Next = Head;
            Head.Prev = doublyLinkedListNodeSM;
            Head = doublyLinkedListNodeSM;
        }

        public void PrintDoublyLinkedListSm()
        {
            while (Head != null)
            {
                Console.WriteLine(Head.Data);
                Head = Head.Next;
            }
        }

        public void AddANodeAfterAGivenData(int d, int a)
        {
            DoublyLinkedListNodeSM doublyLinkedListNodeSM = null;
            DoublyLinkedListNodeSM nodeToAdd = new DoublyLinkedListNodeSM(a);

            DoublyLinkedListNodeSM dummyHead = Head;
            while (dummyHead != null)
            {
                if (dummyHead.Data == d)
                {
                    break;
                }
                dummyHead = dummyHead.Next;
            }
            if (dummyHead == null)
            {
                Console.WriteLine("There is no node with the given data");
                return;
            }
            nodeToAdd.Next = dummyHead.Next;
            nodeToAdd.Prev = dummyHead;
            dummyHead.Next.Prev = nodeToAdd;
            dummyHead.Next = nodeToAdd;

        }

        public DoublyLinkedListNodeSM ReverseTheDoublyLinkedListSm()
        {
            DoublyLinkedListNodeSM prev = null;
            DoublyLinkedListNodeSM current = Head;
            DoublyLinkedListNodeSM next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                if(next!=null)
                    next.Prev = current;
                prev = current;
                current = next;
            }
            return prev;    
        }

        public void DeleteANodeSm(int d)
        {
            DoublyLinkedListNodeSM nodeToDelete = Head;
            
            while (nodeToDelete != null && nodeToDelete.Data != d)
            {
                nodeToDelete = nodeToDelete.Next;
            }
            if (nodeToDelete == null)
            {
                Console.WriteLine("The given data isn't part of doubly linked list");
                return;
            }
            
            nodeToDelete.Prev.Next = nodeToDelete.Next;
            nodeToDelete.Next.Prev = nodeToDelete.Prev;
        }
    }

    public class DoublyLinkedListNodeSM
    {
        public int Data { get; set; }

        public DoublyLinkedListNodeSM Next;
        public DoublyLinkedListNodeSM Prev;
        public DoublyLinkedListNodeSM(int d)
        {
            Data = d;
            Next = null;
            Prev = null;
        }
    }
}
