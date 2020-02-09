using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Populating a binary tree 

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild= new BinaryTreeNodeSM(5);

            #endregion


            #region InOrder transversal Q(n)

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.InOrderTransversal(binaryTreeSM.root);

            #endregion


            #region PreOrder transversal Q(n)

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.PreOrderTransversal(binaryTreeSM.root);

            #endregion


            #region PostOrder transversal Q(n)

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.PostOrderTransversal(binaryTreeSM.root);

            #endregion


            #region Inorder Tree Traversal without Recursion

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.InOrderTransversalWithoutRecursion(binaryTreeSM.root);

            #endregion


            #region Find n-th node of inorder traversal

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //int n = int.Parse(Console.ReadLine());
            //binaryTreeSM.FindNthNodeInorderTransversal(binaryTreeSM.root,ref n);


            #endregion


            #region Find n-th node of PostOrder traversal

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //int n = int.Parse(Console.ReadLine());
            //binaryTreeSM.FindNthNodeInpostTransversal(binaryTreeSM.root, ref n);


            #endregion


            #region Write a Program to Find the Maximum Depth or Height of a Tree Recursive

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.rightChild.leftChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.root.leftChild.rightChild.leftChild.leftChild = new BinaryTreeNodeSM(8);
            //int height = binaryTreeSM.FindHeightSm(binaryTreeSM.root);
            //Console.WriteLine(height);

            #endregion


            #region Iterative Method to find Height of Binary Tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.rightChild.leftChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.root.leftChild.rightChild.leftChild.leftChild = new BinaryTreeNodeSM(8);
            //int height = binaryTreeSM.FindHeightIterativelySm(binaryTreeSM.root);
            //Console.WriteLine(height);

            #endregion


            #region LevelOrder transversal Q(n)

            ////Breadth-First transversal
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.LevelOrderTransversal(binaryTreeSM.root);

            #endregion


            #region Level order transversal using queue

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.LevelOrderTransversalMethod2(binaryTreeSM.root);

            #endregion


            ////Diameter of a Binary Tree
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //int diameter = binaryTreeSM.DiameterOfBinaryTree(binaryTreeSM.root);
            //Console.WriteLine(diameter);



            //Diameter of a Binary Tree optimized
            // TO BE DONE


            #region Inorder Tree Traversal without Recursion

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.InOrderTreeTransversalWithoutRecursion(binaryTreeSM.root);

            #endregion


            ////Print nodes at k distance from root
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.PrintNodeAtKDistance(2, binaryTreeSM.root);



            ////Maximum width of a binary tree
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //int width = binaryTreeSM.MaximumWidthOfTree(binaryTreeSM.root);
            //Console.WriteLine(width);



            ////Maximum width of a binary tree using queue
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //int width = binaryTreeSM.MaximumWidthOfTreeUsingQueue(binaryTreeSM.root);
            //Console.WriteLine(width);




            ////Print Ancestors of a given node in Binary Tree
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.leftChild.leftChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.PrintAncestorsofGivenNode(binaryTreeSM.root, 7);



            #region Populate Inorder Successor for all nodes

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.leftChild.leftChild = new BinaryTreeNodeSM(7);
            ////binaryTreeSM.PopulateNextInOrderSuccessorSM(binaryTreeSM.root);
            //binaryTreeSM.PopulateNextInOrderSuccessorNonStaticSM(binaryTreeSM.root, null);

            //BinaryTreeNodeSM temp = binaryTreeSM.root;
            //while (temp.leftChild != null)
            //{
            //    temp = temp.leftChild;
            //}
            //while (temp != null)
            //{
            //    int d = temp.inorderSuccessorNext != null ?
            //        temp.inorderSuccessorNext.data : -1;
            //    Console.WriteLine(d);
            //    temp = temp.inorderSuccessorNext;
            //}

            #endregion


            #region Level order traversal line by line | Set 3 (Using One Queue)

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.LevelOrderTransversalLineByLineSM(binaryTreeSM.root);


            #endregion


            #region Reverse Level Order Traversal

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.ReverseLevelOrderTransversalSM(binaryTreeSM.root);

            #endregion


            ////Iterative Preorder Traversal
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.IterativePreorderTraversal(binaryTreeSM.root);



            ////Iterative Postorder Traversal
            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.IterativePostorderTraversalUsingTwoStack(binaryTreeSM.root);




            #region Diagonal Traversal of Binary Tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //Dictionary<int, HashSet<int>> keyValuePairs = new Dictionary<int, HashSet<int>>();
            //binaryTreeSM.DiagonalTraversalofBinaryTree(binaryTreeSM.root, 0, keyValuePairs);
            //foreach (var item in keyValuePairs.Keys)
            //{
            //    Console.WriteLine(item);
            //    foreach (var it in keyValuePairs[item])
            //    {
            //        Console.Write(it);
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Iterative diagonal traversal of binary tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.IterativeDiagonaltraversalSM(binaryTreeSM.root);

            #endregion


            #region Check for Children Sum Property in a Binary Tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(10);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(8);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(2);
            //bool t  = binaryTreeSM.ChildrenSumProperty(binaryTreeSM.root);
            //Console.WriteLine(t) ;

            #endregion



            #region Check if a given Binary Tree is SumTree Q(n*2)

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(26);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(10);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(3);
            //bool t = binaryTreeSM.IsBinaryTreeSumTree(binaryTreeSM.root);
            //Console.WriteLine(t);

            #endregion



            #region Boundary Traversal of binary tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(26);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(10);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.leftChild.rightChild.leftChild = new BinaryTreeNodeSM(20);
            //binaryTreeSM.root.leftChild.rightChild.rightChild = new BinaryTreeNodeSM(28);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(33);
            //binaryTreeSM.BoundaryTraversal(binaryTreeSM.root);

            #endregion



            #region Check sum of Covered and Uncovered nodes of Binary Tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(26);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(10);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.leftChild.rightChild.leftChild = new BinaryTreeNodeSM(20);
            //binaryTreeSM.root.leftChild.rightChild.rightChild = new BinaryTreeNodeSM(28);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(33);
            //bool t =binaryTreeSM.CheckSumofCoveredUncoveredNodes(binaryTreeSM.root);
            //Console.WriteLine(t);

            #endregion


            #region Replace each node in binary tree with the sum of its inorder predecessor and successor

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(26);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(10);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.leftChild.rightChild.leftChild = new BinaryTreeNodeSM(20);
            //binaryTreeSM.root.leftChild.rightChild.rightChild = new BinaryTreeNodeSM(28);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(33);
            //binaryTreeSM.ReplaceSumInorderSuccessorPredecessor(binaryTreeSM.root);


            #endregion


            #region Find sum of all left leaves in a given Binary Tree

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(9);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(8);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(6);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild.leftChild= new BinaryTreeNodeSM(1);
            //int sum = binaryTreeSM.SumOfLeftLeaves(binaryTreeSM.root);

            #endregion


            #region Sum of all the parent nodes having child node x

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(3);

            //int sum = 0;
            //binaryTreeSM.SumOfParentNodes(binaryTreeSM.root,2, ref sum);

            #endregion


            #region Check whether a binary tree is a full binary tree or not

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(7);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild.rightChild = new BinaryTreeNodeSM(3);


            //bool isFull = binaryTreeSM.CheckForFullBinaryTree(binaryTreeSM.root);
            //Console.WriteLine(isFull);

            #endregion


            #region Check if two trees are Mirror

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);

            //BinaryTreeSM binaryTreeSM2 = new BinaryTreeSM();
            //binaryTreeSM2.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM2.root.leftChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM2.root.rightChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM2.root.rightChild.leftChild = new BinaryTreeNodeSM(5);
            //binaryTreeSM2.root.rightChild.rightChild = new BinaryTreeNodeSM(4);

            //bool isMirror = binaryTreeSM.CheckMirrorTrees(binaryTreeSM.root, binaryTreeSM2.root);
            //Console.WriteLine(isMirror);

            #endregion


            #region Write Code to Determine if Two Trees are Identical

            //BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            //binaryTreeSM.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);


            //BinaryTreeSM binaryTreeSM2 = new BinaryTreeSM();
            //binaryTreeSM2.root = new BinaryTreeNodeSM(1);
            //binaryTreeSM2.root.leftChild = new BinaryTreeNodeSM(2);
            //binaryTreeSM2.root.rightChild = new BinaryTreeNodeSM(3);
            //binaryTreeSM2.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            //binaryTreeSM2.root.leftChild.rightChild = new BinaryTreeNodeSM(5);

            //bool isIdentical = binaryTreeSM.CheckIdenticalTrees(binaryTreeSM.root, binaryTreeSM2.root);
            //Console.WriteLine(isIdentical);

            #endregion


            #region Write Code to Determine if Two Trees are Identical

            BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            binaryTreeSM.root = new BinaryTreeNodeSM(1);
            binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            binaryTreeSM.root.leftChild.rightChild = new BinaryTreeNodeSM(5);


            BinaryTreeSM binaryTreeSM2 = new BinaryTreeSM();
            binaryTreeSM2.root = new BinaryTreeNodeSM(1);
            binaryTreeSM2.root.leftChild = new BinaryTreeNodeSM(2);
            binaryTreeSM2.root.rightChild = new BinaryTreeNodeSM(3);
            binaryTreeSM2.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            binaryTreeSM2.root.leftChild.rightChild = new BinaryTreeNodeSM(5);

            bool isIdentical = binaryTreeSM.CheckIdenticalTrees(binaryTreeSM.root, binaryTreeSM2.root);
            Console.WriteLine(isIdentical);

            #endregion



            Console.ReadLine();
        }

    }
}
