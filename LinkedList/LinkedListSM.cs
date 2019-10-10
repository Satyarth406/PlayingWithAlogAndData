using System;

namespace LinkedList
{
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

        public void DeleteNodeWithGivenData(int data)
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

        public void DeleteNodeAtAGivenPosition(int position) //starting position is 0
        {
            LinkedListNodeSM dummy = head;
            LinkedListNodeSM dummyBefore = head; //node before the node to be deleted.

            if (dummy == null)
            {
                Console.WriteLine("There are no items in the linked list");
                return;
            }

            if (position == 0)
            {
                head = head.Next;
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

        public void SwapNodesWithSwappingDataSM(int x, int y)
        {
            if (x == y) return;
            LinkedListNodeSM dummyX = head;
            LinkedListNodeSM dummyBeforeX = null;
            LinkedListNodeSM dummyY = head;
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
                head = dummyY;
            }
            else
            {
                dummyBeforeX.Next = dummyY;
            }
            if (dummyBeforeY == null)
            {
                head = dummyX;
            }
            else
            {
                dummyBeforeY.Next = dummyX;
            }
            LinkedListNodeSM dummyXNext = dummyX.Next;
            dummyX.Next = dummyY.Next;
            dummyY.Next = dummyXNext;

        }

        public int FindNthNodeInLinkedList(int v)
        {
            int count = 0;
            LinkedListNodeSM linkedListNodeSM = head;
            while (linkedListNodeSM != null && count != v)
            {
                linkedListNodeSM = linkedListNodeSM.Next;
            }
            if (linkedListNodeSM == null)
                return int.MinValue;
            return linkedListNodeSM.Data;
        }

        public bool FindNodeWithDataRecursively(int v, LinkedListNodeSM head)
        {
            if (head == null)
                return false;
            if (head.Data == v)
                return true;
            return FindNodeWithDataRecursively(v, head.Next);
        }

        public bool FindNodeWithData(int v)
        {
            LinkedListNodeSM linkedListNodeSM = head;
            bool a = false;

            while (linkedListNodeSM != null)
            {
                if (linkedListNodeSM.Data == v)
                {
                    a = true;
                    break;
                }
                linkedListNodeSM = linkedListNodeSM.Next;
            }

            return a;
        }

        public int LengthOfLinkedListSM()
        {
            int count = 0;
            LinkedListNodeSM dummy = head;
            while (dummy != null)
            {
                count++;
                dummy = dummy.Next;
            }
            return count;
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

        public void ReverseLinkedListSM()
        {
            LinkedListNodeSM curr = head;
            LinkedListNodeSM prev = null;
            LinkedListNodeSM next = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;
        }

        public LinkedListNodeSM ReverseLinkedListUsingRecursionSM(LinkedListNodeSM head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            LinkedListNodeSM rest = ReverseLinkedListUsingRecursionSM(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return rest;
        }

        public LinkedListNodeSM MergeTwoSortedLinkedList(LinkedListSM linkedListSm, LinkedListSM linkedListSm2)
        {
            LinkedListNodeSM headFirst = linkedListSm.head;
            LinkedListNodeSM headSecond = linkedListSm2.head;
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

        public LinkedListNodeSM MergeTwoSortedLinkedListUsingRecursion(LinkedListNodeSM linkedListSm, LinkedListNodeSM linkedListSm2)
        {
            LinkedListNodeSM result = null;
            if (linkedListSm == null) return linkedListSm2;
            if (linkedListSm2 == null) return linkedListSm;

            if (linkedListSm.Data < linkedListSm2.Data)
            {
                result = linkedListSm;
                result.Next = MergeTwoSortedLinkedListUsingRecursion(linkedListSm.Next, linkedListSm2);
            }
            else
            {
                result = linkedListSm2;
                result.Next = MergeTwoSortedLinkedListUsingRecursion(linkedListSm, linkedListSm2.Next);
            }

            return result;
        }

        public int FindNthNodeInLinkedListRecursively(int v, LinkedListNodeSM node)
        {
            if (v == 0)
            {
                return node.Data;
            }
            if (node == null)
                return int.MinValue;
            else
                return FindNthNodeInLinkedListRecursively(--v, node.Next);

        }

        public bool DetectAndRemoveLoop(LinkedListSM linkedListSM)
        {
            LinkedListNodeSM slow = linkedListSM.head;
            LinkedListNodeSM fast = linkedListSM.head;
            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                {
                    removeLoop(slow, linkedListSM.head);
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

        public LinkedListNodeSM AddTwoLinkedListTogetherSM(LinkedListSM linkedListSM, LinkedListSM linkedListSM2)
        {
            LinkedListNodeSM result = new LinkedListNodeSM(-1);
            LinkedListNodeSM resulthead = result;

            int carryOver = 0;

            while (linkedListSM.head != null || linkedListSM2.head != null)
            {
                int sum = (linkedListSM.head == null ? 0 : linkedListSM.head.Data) + (linkedListSM2.head == null ? 0 : linkedListSM2.head.Data) + carryOver;
                int d = sum % 10;
                carryOver = sum / 10;
                result.Next = new LinkedListNodeSM(d);
                if (linkedListSM.head != null)
                    linkedListSM.head = linkedListSM.head.Next;
                if (linkedListSM2.head != null)
                    linkedListSM2.head = linkedListSM2.head.Next;
                result = result.Next;
            }
            if (carryOver > 0)
            {
                result.Next = new LinkedListNodeSM(carryOver);
            }
            return resulthead.Next;
        }

        public LinkedListNodeSM ReverseLinkedListInGroupsOfGivenSize(LinkedListNodeSM linkedListSm, int size)
        {
            int count = 0;
            LinkedListNodeSM prev = null;
            LinkedListNodeSM curr = linkedListSm;
            LinkedListNodeSM next;
            LinkedListNodeSM head = curr;

            while (count < size && curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
                count++;
            }

            if (curr != null)
            {
                head.Next = ReverseLinkedListInGroupsOfGivenSize(curr, 3);
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
