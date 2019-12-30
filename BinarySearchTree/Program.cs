using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Insert a node into the binary Search tree

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root,10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);

            #endregion


            #region Search a given node in the binary Search tree

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //BinarySearchTreeNodeSM t = binarySearchTreeSm.FindTheGivenData(binarySearchTreeSm.Root, 12);
            //if (t != null)
            //{
            //    Console.WriteLine("The given key is present in the tree");
            //}


            #endregion


            #region Find the node with minimum value in a Binary Search Tree

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //int min = binarySearchTreeSm.FindTheMinValue(binarySearchTreeSm.Root);
            //Console.WriteLine(min);

            #endregion


            #region Inorder predecessor and successor for a given key in BST

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //BinarySearchTreeNodeSM pred = null, succ = null;
            //binarySearchTreeSm.FindInorderPredecessorAndSuccessorOfKey(binarySearchTreeSm.Root, 13, ref pred, ref succ);
            //Console.WriteLine("Predecessor is " + pred.Data + "  Successor is: " + succ.Data);

            #endregion


            #region A program to check if a binary tree is BST or not

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //bool isBst = binarySearchTreeSm.CheckIfBstOrNot(binarySearchTreeSm.Root);
            //Console.WriteLine(isBst);

            #endregion


            #region Lowest Common Ancestor in a Binary Search Tree

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 20);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 8);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 22);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 4);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 14);
            //BinarySearchTreeNodeSM leastCommonAncestor = binarySearchTreeSm.GetLeastCommonAncestor(binarySearchTreeSm.Root,14,8);
            //Console.WriteLine(leastCommonAncestor.Data);

            #endregion



            #region Inorder Successor in Binary Search Tree

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 20);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 8);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 22);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 4);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 14);
            //BinarySearchTreeNodeSM inOrderSuccessor = binarySearchTreeSm.InOrderSuccessor(binarySearchTreeSm.Root, 10);
            //Console.WriteLine(inOrderSuccessor.Data);

            #endregion


            #region Two nodes of a BST are swapped, correct the BST

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 20);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 8);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 22);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 4);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 14);
            //binarySearchTreeSm.CorrectSwappedNodes(binarySearchTreeSm.Root);
            //binarySearchTreeSm.InOrderTransversal(binarySearchTreeSm.Root);

            #endregion


            #region Floor and Ceil from a BST

            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 8);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 4);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 2);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 6);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 14);
            //BinarySearchTreeNodeSM temp = null;
            //for (int i = 1; i <= 15; i++)
            //{
            //    int t = binarySearchTreeSm.FindCeilSm(binarySearchTreeSm.Root,temp,i);
            //    Console.WriteLine(t);
            //}

            #endregion


            ////Binary Search Tree | Set 2(Delete)
            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 50);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root,30);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 20);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 40);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 70);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 60);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 80);
            //binarySearchTreeSm.DeleteNodeWithData(binarySearchTreeSm.Root, 20);


            #region Sorted order printing of a given array that represents a BST

            //int[] arr = { 4, 2, 5, 1, 3 };
            //SortedOrderPrinting(arr, 0, arr.Length - 1);

            #endregion

            Console.ReadLine();
        }

        private static void SortedOrderPrinting(int[] arr, int start, int end)
        {
            if (start > end) return;
            SortedOrderPrinting(arr, 2 * start + 1, end);
            Console.WriteLine(arr[start]);
            SortedOrderPrinting(arr, 2 * start + 2, end);
        }
    }
}
