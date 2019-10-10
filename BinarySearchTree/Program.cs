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

            ////Insert a node into the binary Search tree
            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root,10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);




            ////Search a given node in the binary Search tree
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




            ////Find the node with minimum value in a Binary Search Tree
            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //int min = binarySearchTreeSm.FindTheMinValue(binarySearchTreeSm.Root);
            //Console.WriteLine(min);




            ////Inorder predecessor and successor for a given key in BST
            //BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            //binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            //BinarySearchTreeNodeSM pred = null, succ = null;
            //binarySearchTreeSm.FindInorderPredecessorAndSuccessorOfKey(binarySearchTreeSm.Root, 13, ref pred, ref succ);
            //Console.WriteLine("Predecessor is " + pred.Data + "  Successor is: " + succ.Data);




            ////A program to check if a binary tree is BST or not
            BinarySearchTreeSM binarySearchTreeSm = new BinarySearchTreeSM();
            binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 10);
            binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 3);
            binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 5);
            binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 15);
            binarySearchTreeSm.Root = binarySearchTreeSm.AddNode(binarySearchTreeSm.Root, 12);
            bool isBst = binarySearchTreeSm.CheckIfBstOrNot(binarySearchTreeSm.Root);
            Console.WriteLine(isBst);







            Console.ReadLine();
        }
    }
}
