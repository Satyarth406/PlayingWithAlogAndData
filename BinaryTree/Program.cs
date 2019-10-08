using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeSM binaryTreeSM = new BinaryTreeSM();
            binaryTreeSM.root = new BinaryTreeNodeSM(1);
            binaryTreeSM.root.leftChild = new BinaryTreeNodeSM(2);
            binaryTreeSM.root.rightChild = new BinaryTreeNodeSM(3);
            binaryTreeSM.root.leftChild.leftChild = new BinaryTreeNodeSM(4);
            binaryTreeSM.root.leftChild.rightChild= new BinaryTreeNodeSM(5);

            ////InOrder transversal
            //binaryTreeSM.InOrderTransversal(binaryTreeSM.root);

            //binaryTreeSM.PreOrderTransversal(binaryTreeSM.root);

            //binaryTreeSM.PostOrderTransversal(binaryTreeSM.root);

            ////Breadth-First transversal
            binaryTreeSM.LevelOrderTransversal(binaryTreeSM.root);

            binaryTreeSM.LevelOrderTransversalMethod2(binaryTreeSM.root);




            Console.ReadLine();
        }

    }
}
