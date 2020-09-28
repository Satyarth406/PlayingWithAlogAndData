using System;
using System.Collections;

namespace LinkedList
{
    public class LinkedListSM
    {
        public LinkedListNodeSM Head;
        public LinkedListNodeSM Last;


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

        //adding a node in the end Q(1*c)  c== constant
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

        //Deleting a node Q(n)
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


        //Delete a Linked List node at a given position  Q(n)
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

        internal bool DetectLoop(LinkedListNodeSM head)
        {
            LinkedListNodeSM slow = head;
            LinkedListNodeSM fast = head.Next;
            while (slow != null && fast != null)
            {
                if (slow == fast)
                {
                    return true;
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return false;
        }


        internal int FindLengthOfTheLoop(LinkedListNodeSM head)
        {
            LinkedListNodeSM slow = head;
            LinkedListNodeSM fast = head.Next;
            while (slow != null && fast != null)
            {
                if (slow == fast)
                {
                    return CountNodesInLoop(slow);
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return 0;
        }

        private int CountNodesInLoop(LinkedListNodeSM slow)
        {
            LinkedListNodeSM temp = slow;
            int count = 1;
            while (temp.Next != slow)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }

        //Write a function to get Nth node in a Linked List Q(n)
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


        //Search an element in a Linked List Recusive  Q(n)
        public bool FindNodeWithDataRecursivelySm(int v, LinkedListNodeSM head)
        {
            if (head == null)
                return false;
            if (head.Data == v)
                return true;
            return FindNodeWithDataRecursivelySm(v, head.Next);
        }


        //Search an element in a Linked List Q(n)
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

        internal void PrintReverse(LinkedListNodeSM head)
        {
            if (head == null) return;
            PrintReverse(head.Next);
            Console.WriteLine(head.Data);
        }


        //Find Length of a Linked List Q(n)
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


        //Find Length of a Linked List Recursive Q(n)
        public int LengthOfLinkedListRecursiveSm(LinkedListNodeSM linkedListNodeSM)
        {
            if (linkedListNodeSM == null) return 0;
            return 1 + LengthOfLinkedListRecursiveSm(linkedListNodeSM.Next);
        }


        //Add a node after a given node (Q(n))
        public void AddNodeAfterAGivenNodeSm(LinkedListNodeSM nodeToInsertAfter, int dataToInsert)
        {
            LinkedListNodeSM newNode = new LinkedListNodeSM(dataToInsert) { Next = nodeToInsertAfter.Next };
            nodeToInsertAfter.Next = newNode;
        }


        //Printing the Linked List (Q(n))
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

        //Reverse a linked list
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


        public LinkedListNodeSM ReverseLinkedListUsingRecursionSm(LinkedListNodeSM nodeSm)
        {
            if (nodeSm?.Next == null) return nodeSm;
            LinkedListNodeSM first = nodeSm;
            LinkedListNodeSM rest = ReverseLinkedListUsingRecursionSm(nodeSm.Next);
            first.Next.Next = first;
            first.Next = null;
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

        internal LinkedListNodeSM ReverseAlternateKnodesSm(LinkedListNodeSM head, int gpSize, bool alternate)
        {
            LinkedListNodeSM prev = null;
            LinkedListNodeSM curr = head;
            LinkedListNodeSM next = null;

            int count = 0;
            if (alternate)
            {
                while (curr != null && count < gpSize)
                {
                    next = curr.Next;
                    curr.Next = prev;
                    prev = curr;
                    curr = next;
                    count++;
                }
                if (curr != null)
                {
                    head.Next = ReverseAlternateKnodesSm(curr, gpSize, !alternate);
                }
            }
            else
            {
                while (count < gpSize)
                {
                    prev = curr;
                    count++;
                    curr = curr.Next;
                }
                if (curr != null)
                {
                    prev.Next = ReverseAlternateKnodesSm(curr, gpSize, !alternate);
                }
                return head;

            }
            return prev;

        }

        internal LinkedListNodeSM DeleteAlternateNodesRecursively(LinkedListNodeSM head)
        {
            if (head == null || head.Next == null) return head;
            head.Next = DeleteAlternateNodesRecursively(head.Next.Next);
            return head;

        }

        internal LinkedListNodeSM DeleteAlternateNodes(LinkedListNodeSM head)
        {
            LinkedListNodeSM dummy = head;
            while (dummy != null && dummy.Next != null)
            {
                dummy.Next = dummy.Next.Next;
                dummy = dummy.Next;
            }
            return head;
        }

        internal LinkedListNodeSM DeleteNodesWithGreaterValueRightSide(LinkedListNodeSM head)
        {
            LinkedListNodeSM reversed = ReverseLinkedListUsingRecursionSm(head);
            LinkedListNodeSM reversedHead = reversed;
            int currMax = 0;
            LinkedListNodeSM prev = null;
            while (reversed != null)
            {
                if (prev == null)
                {
                    prev = reversed;
                    currMax = prev.Data;
                    continue;
                }
                if (reversed.Data > currMax)
                {
                    currMax = reversed.Data;
                }
                else
                {
                    prev.Next = reversed.Next;
                }
                prev = reversed;
                reversed = reversed.Next;
            }
            return ReverseLinkedListUsingRecursionSm(reversedHead);
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


        //Find the middle of a given linked list Q(n)
        internal int FindTheMiddleOfLinkedListSm(LinkedListNodeSM head)
        {
            if (head == null) return int.MinValue;
            LinkedListNodeSM slow = head;
            LinkedListNodeSM fast = head;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            return slow.Data;
        }

        internal int NumberOfTimesAGivenIntOccursRecursiveSm(LinkedListNodeSM head, int val)
        {
            if (head == null) return 0;
            if (head.Data == val) return 1 + NumberOfTimesAGivenIntOccursRecursiveSm(head.Next, val);
            return NumberOfTimesAGivenIntOccursRecursiveSm(head.Next, val);
        }


        //Write a function to get Nth node in a Linked List Recursive Q(n)
        public int FindNthNodeInLinkedListRecursivelySm(int v, LinkedListNodeSM node)
        {
            if (node == null) return int.MinValue;
            if (v == 0) return node.Data;
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


        //Function to check if a singly linked list is palindrome Q(n)
        internal bool CheckIfLinkedListIsPalindromeSm(LinkedListNodeSM head)
        {
            LinkedListNodeSM dummy = head;
            Stack stack = new Stack();
            while (dummy != null)
            {
                stack.Push(dummy.Data);
                dummy = dummy.Next;
            }
            while (stack.Count != 0)
            {
                int poppedItem = (int)stack.Pop();
                if (poppedItem != head.Data) return false;
                head = head.Next;
            }
            return true;
        }



        //Function to check if a singly linked list is palindrome recursive Q(n)
        internal bool CheckIfLinkedListIsPalindromeRecursiveSm(LinkedListNodeSM head)
        {
            bool res = IsPalindrome(head, head);
            return res;
        }

        internal void PairwiseSwapElementsSm(LinkedListNodeSM head)
        {
            LinkedListNodeSM dummy = head;
            while (dummy?.Next != null)
            {
                LinkedListNodeSM first = dummy;
                LinkedListNodeSM second = dummy.Next;
                int temp = first.Data;
                first.Data = second.Data;
                second.Data = temp;
                dummy = dummy.Next.Next;
            }
        }

        private bool IsPalindrome(LinkedListNodeSM left, LinkedListNodeSM right)
        {
            if (right == null) return true;
            bool end = IsPalindrome(left, right.Next);
            if (end == false) return false;
            bool finalRes = left.Data == right.Data;
            left = left.Next;
            return finalRes;
        }

        internal void PairwiseSwapElementsRecursiveSm(LinkedListNodeSM head)
        {
            if (head == null || head.Next == null) return;
            LinkedListNodeSM first = head;
            LinkedListNodeSM second = head.Next;
            int temp = first.Data;
            first.Data = second.Data;
            second.Data = temp;
            PairwiseSwapElementsRecursiveSm(head.Next.Next);
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

        internal LinkedListNodeSM IntersectionoftwoSortedLinkedLists(LinkedListNodeSM head1, LinkedListNodeSM head2)
        {
            LinkedListNodeSM dummy = new LinkedListNodeSM(-10);
            LinkedListNodeSM dummyStart = dummy;

            while (head1 != null && head2 != null)
            {
                if (head1.Data == head2.Data)
                {
                    dummy.Next = new LinkedListNodeSM(head1.Data);
                    head2 = head2.Next;
                    head1 = head1.Next;
                    dummy = dummy.Next;
                }
                else if (head1.Data > head2.Data)
                {
                    head2 = head2.Next;
                }
                else
                {
                    head1 = head1.Next;
                }
            }
            return dummyStart.Next;
        }

        internal void IntersectionoftwoSortedRecursiveSm(LinkedListNodeSM head1, LinkedListNodeSM head2, LinkedListNodeSM dummy)
        {
            if (head1 == null || head2 == null) return;
            if (head2.Data == head1.Data)
            {
                dummy.Next = new LinkedListNodeSM(head1.Data);
                IntersectionoftwoSortedRecursiveSm(head1.Next, head2.Next, dummy.Next);
            }
            else if (head2.Data > head1.Data)
            {
                IntersectionoftwoSortedRecursiveSm(head1.Next, head2, dummy);
            }
            else
            {
                IntersectionoftwoSortedRecursiveSm(head1, head2.Next, dummy);
            }
        }

        internal LinkedListNodeSM SegregateEvenOddNodes(LinkedListNodeSM head)
        {
            LinkedListNodeSM oddStart = null;
            LinkedListNodeSM oddend = null;
            LinkedListNodeSM evenStart = null;
            LinkedListNodeSM evenEnd = null;
            LinkedListNodeSM dummy = head;
            while (dummy != null)
            {
                if (dummy.Data % 2 == 0)
                {
                    if (evenStart == null)
                    {
                        evenStart = dummy;
                        evenEnd = dummy;
                    }
                    else
                    {
                        evenEnd.Next = dummy;
                        evenEnd = evenEnd.Next;

                    }
                }
                else
                {
                    if (oddStart == null)
                    {
                        oddStart = dummy;
                        oddend = dummy;
                    }
                    else
                    {
                        oddend.Next = dummy;
                        oddend = oddend.Next;
                    }
                }
                dummy = dummy.Next;
            }
            oddend.Next = null;
            evenEnd.Next = oddStart;
            return evenStart;

        }

        public LinkedListNodeSM ReverseLinkedListInGroupsOfGivenSizeSm(LinkedListNodeSM linkedListSm, int size)
        {
            int count = 0;
            LinkedListNodeSM prev = null;
            LinkedListNodeSM current = linkedListSm;
            LinkedListNodeSM next;
            LinkedListNodeSM head = current;

            while (count < size && current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
                count++;
            }

            if (current != null)
            {
                head.Next = ReverseLinkedListInGroupsOfGivenSizeSm(current, 3);
            }

            return prev;
        }
    }

    /// <summary>
    /// class representing a node in the linked list
    /// </summary>
    public class LinkedListNodeSM
    {
        public int Data { get; set; }
        public LinkedListNodeSM Next { get; set; }
        public LinkedListNodeSM(int d)
        {
            Data = d;
        }
    }

}
