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

        /// <summary>
        /// Add a node at the end
        /// </summary>
        /// <param name="data"></param>
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

        /// <summary>
        /// add a node at the start
        /// </summary>
        /// <param name="data"></param>
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

        /// <summary>
        /// print the dll
        /// </summary>
        public void PrintDoublyLinkedListSm()
        {
            while (Head != null)
            {
                Console.WriteLine(Head.Data);
                Head = Head.Next;
            }
        }

        /// <summary>
        /// Add a node after a given node
        /// </summary>
        /// <param name="d">given node data</param>
        /// <param name="a">node data to be added</param>
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

        /// <summary>
        /// Find a pair with given sum in sorted dll 
        /// </summary>
        /// <param name="sum">given sum</param>
        public void FindPairWithGivenSumInDll(int sum)
        {
            DoublyLinkedListNodeSM start = Head;
            DoublyLinkedListNodeSM end = Last;
            while (start != end)
            {
                if (start.Data + end.Data == sum)
                {
                    Console.WriteLine($"The pair with sum {sum} is {start.Data}:{end.Data}");
                    break;
                }
                else if(start.Data + end.Data < sum)
                {
                    start = start.Next;
                }
                else
                {
                    end = end.Prev;
                }
            }
            if(start == end)
            {
                Console.WriteLine($"The given pair is not present");
            }

        }

        internal void DeleteAllOccurencesOfGivenKey(int v)
        {
            DoublyLinkedListNodeSM temp = Head;
            while (temp != null)
            {
                if(temp.Data == v)
                {
                    if (temp.Prev != null)
                    {
                        temp.Prev.Next = temp.Next;
                    }
                    else
                    {
                        Head = temp.Next; 
                    }
                    if (temp.Next != null)
                    {
                        temp.Next.Prev = temp.Prev;
                    }
                    else
                    {
                        Last = temp.Prev;
                    }
                }
                temp = temp.Next;
            }
            PrintDoublyLinkedListSm();
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
                current.Prev = next;
                prev = current;
                current = next;
            }
            return prev;
        }

        /// <summary>
        /// Delete a given data node 
        /// </summary>
        /// <param name="d">node data to be deleted</param>
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
            if (nodeToDelete.Prev != null)
            {
                nodeToDelete.Prev.Next = nodeToDelete.Next;
                Head = nodeToDelete.Next;
            }
            if (nodeToDelete.Next != null)
            {
                nodeToDelete.Next.Prev = nodeToDelete.Prev;
                Last = nodeToDelete.Prev;
            }
            nodeToDelete = null;
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
        }
    }
}
