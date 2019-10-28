using System;

namespace LinkedList
{
    public class LinkedListSM
    {
        public LinkedListNodeSM Head;
        public LinkedListNodeSM Last;
        public LinkedListSM()
        {
            Head = null;
            Last = null;
        }


        /// <summary>
        /// returns the created node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public LinkedListNodeSM AddNodeAtFirstSm(int data)
        {
            LinkedListNodeSM n = new LinkedListNodeSM(data);
            if (Head == null)
            {
                Head = n;
                Last = Head;
                return Head;
            }
            n.Next = Head;
            Head = n;
            return Head;
        }

        public LinkedListNodeSM AddNodeAtLastSm(int data)
        {
            LinkedListNodeSM n = new LinkedListNodeSM(data);
            if (Head == null)
            {
                Head = n;
                Last = Head;
                return Head;
            }
            Last.Next = n;
            Last = n;
            return n;
        }

        public void DeleteNodeWithGivenDataSm(int data)
        {
            LinkedListNodeSM dummy = Head;
            LinkedListNodeSM dummyBefore = Head; //node before the node to be deleted.

            if (dummy == null)
            {
                Console.WriteLine("There are no items in the linked list");
                return;
            }

            if (dummy.Data == data)
            {
                Head = Head.Next;
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

        public void DeleteNodeAtAGivenPositionSm(int position) //starting position is 0
        {
            LinkedListNodeSM dummy = Head;
            LinkedListNodeSM dummyBefore = Head; //node before the node to be deleted.

            if (dummy == null)
            {
                Console.WriteLine("There are no items in the linked list");
                return;
            }

            if (position == 0)
            {
                Head = Head.Next;
                return;
            }
            int count = 0;
            while (dummy != null && count != position)
            {
                count++;
                dummyBefore = dummy;
                dummy = dummy.Next;
            }
            if (dummy == null)
            {
                Console.WriteLine("There position is outside the length of the linked list");
                return;
            }
            dummyBefore.Next = dummy.Next;

        }

        public void SwapNodesWithSwappingDataSm(int x, int y)
        {
            if (x == y) return;
            LinkedListNodeSM dummyX = Head;
            LinkedListNodeSM dummyBeforeX = null;
            LinkedListNodeSM dummyY = Head;
            LinkedListNodeSM dummyBeforeY = null;

            while (dummyX != null && dummyX.Data != x)
            {
                dummyBeforeX = dummyX;
                dummyX = dummyX.Next;
            }

            while (dummyY != null && dummyY.Data != y)
            {
                dummyBeforeY = dummyY;
                dummyY = dummyY.Next;
            }
            if (dummyX == null || dummyY == null)
            {
                Console.WriteLine("either one or both of the data aren't in the linked list");
                return;
            }

            if (dummyBeforeX == null)
            {
                Head = dummyY;
            }
            else
            {
                dummyBeforeX.Next = dummyY;
            }
            if (dummyBeforeY == null)
            {
                Head = dummyX;
            }
            else
            {
                dummyBeforeY.Next = dummyX;
            }
            LinkedListNodeSM dummyXNext = dummyX.Next;
            dummyX.Next = dummyY.Next;
            dummyY.Next = dummyXNext;

        }

        public int FindNthNodeInLinkedListSm(int v)
        {
            int count = 0;
            LinkedListNodeSM linkedListNodeSM = Head;
            while (linkedListNodeSM != null && count != v)
            {
                linkedListNodeSM = linkedListNodeSM.Next;
            }
            if (linkedListNodeSM == null)
                return int.MinValue;
            return linkedListNodeSM.Data;
        }

        public bool FindNodeWithDataRecursivelySm(int v, LinkedListNodeSM head)
        {
            if (head == null)
                return false;
            if (head.Data == v)
                return true;
            return FindNodeWithDataRecursivelySm(v, head.Next);
        }

        public bool FindNodeWithDataSm(int v)
        {
            LinkedListNodeSM linkedListNodeSm = Head;
            bool a = false;

            while (linkedListNodeSm != null)
            {
                if (linkedListNodeSm.Data == v)
                {
                    a = true;
                    break;
                }
                linkedListNodeSm = linkedListNodeSm.Next;
            }

            return a;
        }

        public int LengthOfLinkedListSm()
        {
            int count = 0;
            LinkedListNodeSM dummy = Head;
            while (dummy != null)
            {
                count++;
                dummy = dummy.Next;
            }
            return count;
        }

        public void AddNodeAfterAGivenNodeSm(LinkedListNodeSM nodeToInsertAfter, int dataToInsert)
        {
            LinkedListNodeSM newNode = new LinkedListNodeSM(dataToInsert) {Next = nodeToInsertAfter.Next};
            nodeToInsertAfter.Next = newNode;
        }

        public void PrintLinkedListSm()
        {
            if (Head == null)
            {
                Console.WriteLine("No items in the linked list");
                return;
            }
            LinkedListNodeSM nodeIterator = Head;
            while (nodeIterator != null)
            {
                Console.WriteLine(nodeIterator.Data);
                nodeIterator = nodeIterator.Next;
            }
        }

        public void ReverseLinkedListSm()
        {
            LinkedListNodeSM current = Head;
            LinkedListNodeSM prev = null;
            LinkedListNodeSM next;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        public LinkedListNodeSM ReverseLinkedListUsingRecursionSm(LinkedListNodeSM linkedList)
        {
            if (linkedList?.Next == null)
            {
                return linkedList;
            }
            LinkedListNodeSM rest = ReverseLinkedListUsingRecursionSm(linkedList.Next);
            linkedList.Next.Next = linkedList;
            linkedList.Next = null;
            return rest;
        }

        public LinkedListNodeSM MergeTwoSortedLinkedListSm(LinkedListSM linkedListSm, LinkedListSM linkedListSm2)
        {
            LinkedListNodeSM headFirst = linkedListSm.Head;
            LinkedListNodeSM headSecond = linkedListSm2.Head;
            LinkedListNodeSM dummy = new LinkedListNodeSM(-1);
            LinkedListNodeSM dummyHead = dummy;

            while (headFirst != null && headSecond != null)
            {
                if (headFirst.Data < headSecond.Data)
                {
                    dummy.Next = headFirst;
                    headFirst = headFirst.Next;

                }
                else
                {
                    dummy.Next = headSecond;
                    headSecond = headSecond.Next;
                }
                dummy = dummy.Next;
            }

            while (headFirst != null)
            {
                dummy.Next = headFirst;
                headFirst = headFirst.Next;
                dummy = dummy.Next;
            }

            while (headSecond != null)
            {
                dummy.Next = headSecond;
                headSecond = headSecond.Next;
                dummy = dummy.Next;
            }

            return dummyHead.Next;
        }

        public LinkedListNodeSM MergeTwoSortedLinkedListUsingRecursionSm(LinkedListNodeSM linkedListSm, LinkedListNodeSM linkedListSm2)
        {
            LinkedListNodeSM result = null;
            if (linkedListSm == null) return linkedListSm2;
            if (linkedListSm2 == null) return linkedListSm;

            if (linkedListSm.Data < linkedListSm2.Data)
            {
                result = linkedListSm;
                result.Next = MergeTwoSortedLinkedListUsingRecursionSm(linkedListSm.Next, linkedListSm2);
            }
            else
            {
                result = linkedListSm2;
                result.Next = MergeTwoSortedLinkedListUsingRecursionSm(linkedListSm, linkedListSm2.Next);
            }

            return result;
        }

        public int FindNthNodeInLinkedListRecursivelySm(int v, LinkedListNodeSM node)
        {
            if (v == 0)
            {
                return node.Data;
            }
            if (node == null)
                return int.MinValue;
            else
                return FindNthNodeInLinkedListRecursivelySm(--v, node.Next);

        }

        public bool DetectAndRemoveLoopSm(LinkedListSM linkedListSM)
        {
            LinkedListNodeSM slow = linkedListSM.Head;
            LinkedListNodeSM fast = linkedListSM.Head;
            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    removeLoop(slow, linkedListSM.Head);
                    return true;
                }
            }
            return false;
        }

        private void removeLoop(LinkedListNodeSM nodeInLoop, LinkedListNodeSM head)
        {
            LinkedListNodeSM trialhead = head;
            LinkedListNodeSM trialNode;

            while (1 == 1)
            {
                trialNode = nodeInLoop;
                while (trialNode.Next != nodeInLoop && trialNode.Next != trialhead)
                {
                    trialNode = trialNode.Next;
                }
                if (trialNode.Next == trialhead)
                {
                    break;
                }
                trialhead = trialhead.Next;
            }
            trialNode.Next = null;


        }

        public LinkedListNodeSM AddTwoLinkedListTogetherSm(LinkedListSM linkedListSm, LinkedListSM linkedListSm2)
        {
            LinkedListNodeSM result = new LinkedListNodeSM(-1);
            LinkedListNodeSM resulthead = result;

            int carryOver = 0;

            while (linkedListSm.Head != null || linkedListSm2.Head != null)
            {
                int sum = (linkedListSm.Head?.Data ?? 0) + (linkedListSm2.Head?.Data ?? 0) + carryOver;
                int d = sum % 10;
                carryOver = sum / 10;
                result.Next = new LinkedListNodeSM(d);
                if (linkedListSm.Head != null)
                    linkedListSm.Head = linkedListSm.Head.Next;
                if (linkedListSm2.Head != null)
                    linkedListSm2.Head = linkedListSm2.Head.Next;
                result = result.Next;
            }
            if (carryOver > 0)
            {
                result.Next = new LinkedListNodeSM(carryOver);
            }
            return resulthead.Next;
        }

        public LinkedListNodeSM ReverseLinkedListInGroupsOfGivenSizeSm(LinkedListNodeSM linkedListSm, int size)
        {
            int count = 0;
            LinkedListNodeSM prev = null;
            LinkedListNodeSM currrent = linkedListSm;
            LinkedListNodeSM next;
            LinkedListNodeSM head = currrent;

            while (count < size && currrent != null)
            {
                next = currrent.Next;
                currrent.Next = prev;
                prev = currrent;
                currrent = next;
                count++;
            }

            if (currrent != null)
            {
                head.Next = ReverseLinkedListInGroupsOfGivenSizeSm(currrent, 3);
            }

            return prev;
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
