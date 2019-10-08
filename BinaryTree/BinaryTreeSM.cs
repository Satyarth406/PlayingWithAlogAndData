using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeSM
    {
        public BinaryTreeNodeSM root;

        public void InOrderTransversal(BinaryTreeNodeSM node)
        {
            if (node.leftChild == null && node.rightChild == null)
            {
                Console.WriteLine(node.data);
                return;
            }
            InOrderTransversal(node.leftChild);
            Console.WriteLine(node.data);
            InOrderTransversal(node.rightChild);
        }

        public void PreOrderTransversal(BinaryTreeNodeSM node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.data);
            PreOrderTransversal(node.leftChild);
            PreOrderTransversal(node.rightChild);

        }

        public void LevelOrderTransversal(BinaryTreeNodeSM node)
        {
            if (node == null)
            {
                return;
            }
            LevelOrderTransversal(node.leftChild);
            LevelOrderTransversal(node.rightChild);
            Console.WriteLine(node.data);

        }

        public void LevelOrderTransversalMethod2(BinaryTreeNodeSM node)
        {
            Queue q = new Queue();
            if (node == null) return;
            q.Enqueue(node);
            while (q.Count != 0)
            {
                BinaryTreeNodeSM d = (BinaryTreeNodeSM)q.Dequeue();
                Console.WriteLine(d.data);
                if (d.leftChild != null)
                {
                    q.Enqueue(d.leftChild);
                }
                if (d.rightChild != null)
                {
                    q.Enqueue(d.rightChild);
                }
            }
        }

        public void BreadthFirstTransversal(BinaryTreeNodeSM node)
        {
            int height = HeightSM(node);
            for (int i = 1; i <= height; i++)
            {
                PrintLevel(i,node);
            }
        }

        private void PrintLevel(int level,BinaryTreeNodeSM node)
        {
            if (node == null) return;
            if (level == 1)
            {
                Console.WriteLine(node.data);
                return;
            }
            else
            {
                level--;
                PrintLevel(level, node.leftChild);
                PrintLevel(level, node.rightChild);
            }
            


        }

        public int HeightSM(BinaryTreeNodeSM node)
        {
            if (node == null) return 0;
            int leftHeight = 1 + HeightSM(node.leftChild);
            int rightHeight = 1 + HeightSM(node.rightChild);

            return Math.Max(leftHeight, rightHeight);
        }
    }

    public class BinaryTreeNodeSM
    {
        public int data;
        public BinaryTreeNodeSM leftChild;
        public BinaryTreeNodeSM rightChild;
        public BinaryTreeNodeSM(int d)
        {
            data = d;
            leftChild = null;
            rightChild = null;
        }
    }
}
