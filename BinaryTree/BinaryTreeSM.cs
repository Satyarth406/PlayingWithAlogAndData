using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree
{
    public class BinaryTreeSM
    {
        public BinaryTreeNodeSM root;
        static BinaryTreeNodeSM nextInOrderSuccess = null;
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

        internal int FindHeightSm(BinaryTreeNodeSM root)
        {
            if (root == null) return 0;
            int lHeight = FindHeightSm(root.leftChild);
            int rHeight = FindHeightSm(root.rightChild);
           
            return 1 + Math.Max(lHeight, rHeight);
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

        internal void PopulateNextInOrderSuccessorSM(BinaryTreeNodeSM root)
        {
            if (root == null) return;
            PopulateNextInOrderSuccessorSM(root.rightChild);
            root.inorderSuccessorNext = nextInOrderSuccess;
            nextInOrderSuccess = root;
            PopulateNextInOrderSuccessorSM(root.leftChild);
        }

        internal void PopulateNextInOrderSuccessorNonStaticSM(BinaryTreeNodeSM root, BinaryTreeNodeSM next)
        {
            if (root == null) return;
            PopulateNextInOrderSuccessorNonStaticSM(root.rightChild, next);
            root.inorderSuccessorNext = next;
            next = root;
            PopulateNextInOrderSuccessorNonStaticSM(root.leftChild, next);
        }

        internal void LevelOrderTransversalLineByLineSM(BinaryTreeNodeSM root)
        {
            Queue<BinaryTreeNodeSM> q = new Queue<BinaryTreeNodeSM>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int count = q.Count;
                while (count != 0)
                {
                    BinaryTreeNodeSM binaryTreeNodeSM = q.Dequeue();
                    Console.Write(binaryTreeNodeSM.data);
                    if (binaryTreeNodeSM.leftChild != null)
                    {
                        q.Enqueue(binaryTreeNodeSM.leftChild);
                    }
                    if (binaryTreeNodeSM.rightChild != null)
                    {
                        q.Enqueue(binaryTreeNodeSM.rightChild);
                    }
                    count--;
                }
                Console.WriteLine();
            }
        }

        internal void ReverseLevelOrderTransversalSM(BinaryTreeNodeSM root)
        {
            Queue<BinaryTreeNodeSM> q = new Queue<BinaryTreeNodeSM>();
            Stack<BinaryTreeNodeSM> s = new Stack<BinaryTreeNodeSM>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                BinaryTreeNodeSM binaryTreeNodeSM = q.Dequeue();
                s.Push(binaryTreeNodeSM);
                if (binaryTreeNodeSM.rightChild != null)
                {
                    q.Enqueue(binaryTreeNodeSM.rightChild);
                }
                if (binaryTreeNodeSM.leftChild != null)
                {
                    q.Enqueue(binaryTreeNodeSM.leftChild);
                }
            }
            while (s.Count>0 )
            {
                Console.WriteLine(s.Pop().data);
            }
        }

        internal void PerfectBinaryTreeSpecificLevelOrderTraversalSM(BinaryTreeNodeSM root)
        {
            
        }

        internal void IterativePreorderTraversal(BinaryTreeNodeSM root)
        {
            Stack<BinaryTreeNodeSM> s = new Stack<BinaryTreeNodeSM>();
            s.Push(root);
            while (s.Count > 0)
            {
                BinaryTreeNodeSM p = s.Pop();
                Console.WriteLine(p.data);
                if (p.rightChild != null)
                {
                    s.Push(p.rightChild);
                }
                if (p.leftChild != null)
                {
                    s.Push(p.leftChild);
                }
            }
        }

        internal void IterativePostorderTraversalUsingTwoStack(BinaryTreeNodeSM root)
        {
            Stack<BinaryTreeNodeSM> s1 = new Stack<BinaryTreeNodeSM>();
            Stack<BinaryTreeNodeSM> s2 = new Stack<BinaryTreeNodeSM>();
            s1.Push(root);
            while (s1.Count > 0)
            {
                BinaryTreeNodeSM b = s1.Pop();
                s2.Push(b);
                if (b.leftChild != null)
                {
                    s1.Push(b.leftChild);
                }
                if (b.rightChild != null)
                {
                    s1.Push(b.rightChild);
                }
            }
            while (s2.Count > 0)
            {
                Console.WriteLine(s2.Pop().data);
            }
        }

        internal void DiagonalTraversalofBinaryTree(BinaryTreeNodeSM root, int v, Dictionary<int, List<int>> keyValuePairs)
        {
            if (root != null)
            {
                if (keyValuePairs.ContainsKey(v))
                {
                    keyValuePairs[v].Add(root.data);
                }
                else
                {
                    keyValuePairs.Add(v,new List<int>() { root.data });
                }
                if (root.leftChild != null)
                {
                    DiagonalTraversalofBinaryTree(root.leftChild, v+1,keyValuePairs);
                }
                if (root.rightChild != null)
                {
                    DiagonalTraversalofBinaryTree(root.rightChild, v,keyValuePairs);
                }
            }
        }

        internal void IterativeDiagonaltraversalSM(BinaryTreeNodeSM root)
        {
            if (root == null) return;
            Queue q = new Queue();
            q.Enqueue(root);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryTreeNodeSM temp = (BinaryTreeNodeSM)q.Dequeue();
                if (temp == null)
                {
                    if (q.Count == 0) return;
                    Console.WriteLine();
                    q.Enqueue(null);
                }
                else
                {
                    while (temp != null)
                    {
                        Console.Write(temp.data);
                        if (temp.leftChild != null)
                        {
                            q.Enqueue(temp.leftChild);
                        }
                        temp = temp.rightChild;
                    }
                }
            }
        }
    }
}

public class BinaryTreeNodeSM
{
    public int data;
    public BinaryTreeNodeSM leftChild;
    public BinaryTreeNodeSM rightChild;
    public BinaryTreeNodeSM inorderSuccessorNext;

    public BinaryTreeNodeSM(int d)
    {
        data = d;
    }
}

