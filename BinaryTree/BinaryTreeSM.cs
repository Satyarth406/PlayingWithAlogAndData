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
            if (node == null)
            {
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

        public void PostOrderTransversal(BinaryTreeNodeSM node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTransversal(node.leftChild);
            PostOrderTransversal(node.rightChild);
            Console.WriteLine(node.data);

        }

        public void LevelOrderTransversal(BinaryTreeNodeSM node)
        {
            if (node == null) return;
            int height = HeightSM(node);
            for (int i = 1; i <= height; i++)
            {
                PrintLevel(i, node);
            }
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
                PrintLevel(i, node);
            }
        }

        private void PrintLevel(int level, BinaryTreeNodeSM node)
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
            int leftHeight = HeightSM(node.leftChild);
            int rightHeight = HeightSM(node.rightChild);

            if (leftHeight > rightHeight)
                return 1 + leftHeight;
            else
                return 1 + rightHeight;
        }

        public int DiameterOfBinaryTree(BinaryTreeNodeSM node)
        {
            if (node == null) return 0;
            int lheight = HeightSM(node.leftChild);
            int rheight = HeightSM(node.rightChild);
            int ldiameter = DiameterOfBinaryTree(node.leftChild);
            int rDiameter = DiameterOfBinaryTree(node.rightChild);
            return Math.Max(1 + lheight + rheight, Math.Max(ldiameter, rDiameter));
        }

        public void InOrderTreeTransversalWithoutRecursion(BinaryTreeNodeSM root)
        {
            Stack<BinaryTreeNodeSM> s = new Stack<BinaryTreeNodeSM>();
            while (root != null || s.Count > 0)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.leftChild;
                }
                root = s.Pop();
                Console.WriteLine(root.data);
                root = root.rightChild;
            }
        }

        public void PrintNodeAtKDistance(int k, BinaryTreeNodeSM root)
        {
            if (root == null) return;
            if (k == 1)
            {
                Console.WriteLine(root.data);
                return;
            }
            PrintNodeAtKDistance(k - 1, root.leftChild);
            PrintNodeAtKDistance(k - 1, root.rightChild);

        }

        public int MaximumWidthOfTree(BinaryTreeNodeSM root)
        {
            if (root == null) return int.MinValue;
            int height = HeightSM(root);
            int maxWidth = -1;
            for (int i = 1; i <= height; i++)
            {
                int w = WidthSM(i, root);
                if (w > maxWidth) maxWidth = w;
            }
            return maxWidth;
        }

        private int WidthSM(int i, BinaryTreeNodeSM root)
        {
            if (root == null) return 0;
            if (i == 1) return 1;
            return WidthSM(i - 1, root.leftChild) + WidthSM(i - 1, root.rightChild);
        }

        public int MaximumWidthOfTreeUsingQueue(BinaryTreeNodeSM root)
        {
            if (root == null) return 0;
            Queue<BinaryTreeNodeSM> queu = new Queue<BinaryTreeNodeSM>();
            queu.Enqueue(root);
            int result = 0;
            while (queu.Count > 0)
            {
                int s = queu.Count();
                if (s > result)
                {
                    result = s;
                }
                while (s-- > 0)
                {
                    BinaryTreeNodeSM b = queu.Dequeue();
                    if (b.leftChild != null)
                    {
                        queu.Enqueue(b.leftChild);
                    }
                    if (b.rightChild != null)
                    {
                        queu.Enqueue(b.rightChild);
                    }
                }
            }
            return result;
        }

        public bool PrintAncestorsofGivenNode(BinaryTreeNodeSM root, int pa)
        {
            if (root == null) return false;
            if (root.data == pa) return true;
            bool z = PrintAncestorsofGivenNode(root.leftChild, pa) || PrintAncestorsofGivenNode(root.rightChild, pa);
            if (z)
            {
                Console.WriteLine(root.data);
                return true;
            }
            return false;
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
