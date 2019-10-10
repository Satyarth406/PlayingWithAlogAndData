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
            if(root ==null) return;
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
