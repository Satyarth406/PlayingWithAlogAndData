using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTreeSM
    {
        public BinarySearchTreeNodeSM Root;
        public BinarySearchTreeNodeSM AddNode(BinarySearchTreeNodeSM node, int data)
        {
            if (node == null)
            {
                node = new BinarySearchTreeNodeSM(data);
                return node;
            }

            if (node.Data < data)
            {
                node.RightChild = AddNode(node.RightChild, data);
            }
            else
            {
                node.LeftChild = AddNode(node.LeftChild, data);
            }

            return node;
        }

        public BinarySearchTreeNodeSM FindTheGivenData(BinarySearchTreeNodeSM root, int d)
        {
            if (root == null) return null;
            if (root.Data == d) return root;
            if (root.Data > d)
            {
                return FindTheGivenData(root.LeftChild, d);
            }
            else
            {
                return FindTheGivenData(root.RightChild, d);
            }
        }

        public int FindTheMinValue(BinarySearchTreeNodeSM root)
        {
            if (root.LeftChild == null)
            {
                return root.Data;
            }

            return FindTheMinValue(root.LeftChild);
        }

        public void FindInorderPredecessorAndSuccessorOfKey(BinarySearchTreeNodeSM root, int i, ref BinarySearchTreeNodeSM pred, ref BinarySearchTreeNodeSM succ)
        {
            if (root == null) return;
            if (root.Data == i)
            {
                BinarySearchTreeNodeSM dummy = root.LeftChild;
                while (dummy.RightChild != null)
                {
                    dummy = dummy.RightChild;
                }

                pred = dummy;
                if (root.RightChild != null)
                {
                    dummy = dummy.LeftChild;
                }

                succ = dummy;
                return;
            }
            if (root.Data > i)
            {
                succ = root;
                FindInorderPredecessorAndSuccessorOfKey(root.LeftChild, i, ref pred, ref succ);
            }

            if (root.Data < i)
            {
                pred = root;
                FindInorderPredecessorAndSuccessorOfKey(root.RightChild, i, ref pred, ref succ);
            }
        }

        public bool CheckIfBstOrNot(BinarySearchTreeNodeSM node)
        {
            if (node == null) return true;
            if (node.LeftChild != null && MaxNodeValue(node.LeftChild) > node.Data) return false;
            if (node.RightChild != null && MinNodeValue(node.RightChild) < node.Data) return false;

            return CheckIfBstOrNot(node.LeftChild) && CheckIfBstOrNot(node.RightChild);
        }

        private int MinNodeValue(BinarySearchTreeNodeSM nodeRightChild)
        {
            while (nodeRightChild.LeftChild != null)
            {
                nodeRightChild = nodeRightChild.LeftChild;
            }

            return nodeRightChild.Data;
        }

        private int MaxNodeValue(BinarySearchTreeNodeSM nodeLeftChild)
        {
            while (nodeLeftChild.RightChild != null)
            {
                nodeLeftChild = nodeLeftChild.RightChild;
            }

            return nodeLeftChild.Data;
        }

        public BinarySearchTreeNodeSM GetLeastCommonAncestor(BinarySearchTreeNodeSM node, int a, int b)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Data >= a && node.Data <= b)
            {
                return node;
            }

            if (node.Data > a && node.Data > b)
            {
                return GetLeastCommonAncestor(node.LeftChild, a, b);
            }
            return GetLeastCommonAncestor(node.RightChild, a, b);

        }

        public BinarySearchTreeNodeSM InOrderSuccessor(BinarySearchTreeNodeSM node, int i)
        {
            if (node == null)
                return null;
            BinarySearchTreeNodeSM successorOf = FindTheGivenData(node, i);
            BinarySearchTreeNodeSM successorNode = InOrderSuccessorNode(node, successorOf);
            return successorNode;
        }

        private BinarySearchTreeNodeSM InOrderSuccessorNode(BinarySearchTreeNodeSM node, BinarySearchTreeNodeSM successorOf)
        {
            if (successorOf.RightChild != null)
            {
                BinarySearchTreeNodeSM temp = successorOf.RightChild;
                while (temp.LeftChild != null)
                {
                    temp = temp.LeftChild;
                }

                return temp;
            }

            BinarySearchTreeNodeSM temp2 = null;
            while (node != null)
            {
                if (node.Data < successorOf.Data)
                {
                    node = node.RightChild;
                }
                else if (node.Data > successorOf.Data)
                {
                    temp2 = node;
                    node = node.LeftChild;
                }
                else
                {
                    break;
                }

            }

            return temp2;
        }

        public void CorrectSwappedNodes(BinarySearchTreeNodeSM root)
        {
            BinarySearchTreeNodeSM first = null, prev = null, last = null, middle = null;
            CorrectSwappedNodesUtil(root, ref first, ref middle, ref last, ref prev);
            if (first != null && last != null)
            {
                swap(ref first.Data, ref last.Data);
            }
            else if (first != null && middle != null)
                swap(ref first.Data, ref middle.Data);
        }

        private void swap(ref int firstData, ref int lastData)
        {
            int temp = firstData;
            firstData = lastData;
            lastData = temp;
        }

        private void CorrectSwappedNodesUtil(BinarySearchTreeNodeSM root, ref BinarySearchTreeNodeSM first,
            ref BinarySearchTreeNodeSM middle, ref BinarySearchTreeNodeSM last, ref BinarySearchTreeNodeSM prev)
        {
            if (root == null) return;
            CorrectSwappedNodesUtil(root.LeftChild, ref first, ref middle, ref last, ref prev);
            if (prev != null && root.Data < prev.Data)
            {
                if (first == null)
                {
                    first = prev;
                    middle = root;
                }
                else
                {
                    last = root;
                }
            }

            prev = root;
            CorrectSwappedNodesUtil(root.RightChild, ref first, ref middle, ref last, ref prev);

        }

        public void InOrderTransversal(BinarySearchTreeNodeSM root)
        {
            if(root==null)return;
            InOrderTransversal(root.LeftChild);
            Console.WriteLine(root.Data);
            InOrderTransversal(root.RightChild);

        }
    }
    public class BinarySearchTreeNodeSM
    {
        public int Data;
        public BinarySearchTreeNodeSM LeftChild;
        public BinarySearchTreeNodeSM RightChild;

        public BinarySearchTreeNodeSM(int d)
        {
            Data = d;
            LeftChild = null;
            RightChild = null;
        }
    }
}
