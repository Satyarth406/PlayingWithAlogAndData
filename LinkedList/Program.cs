﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Add Node at the start and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtFirstSM(1);
            //linkedListSM.AddNodeAtFirstSM(2);
            //linkedListSM.AddNodeAtFirstSM(3);
            //linkedListSM.AddNodeAtFirstSM(4);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////add node at the end and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();


            ////add node after a given node and print it
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //LinkedListNodeSM node1 = linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////add node after a given node
            //linkedListSM.AddNodeAfterAGivenNodeSM(node1, 12);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            ////Delete a node with the given data
            //LinkedListSM linkedListSM = new LinkedListSM();
            //linkedListSM.AddNodeAtLastSM(1);
            //linkedListSM.AddNodeAtLastSM(2);
            //linkedListSM.AddNodeAtLastSM(3);
            //linkedListSM.AddNodeAtLastSM(4);
            ////linkedListSM.DeleNodeWithGivenData(3);
            ////Print The linked List
            //linkedListSM.PrintLinkedListSM();



            //Delete a node at a given position
            LinkedListSM linkedListSM = new LinkedListSM();
            linkedListSM.AddNodeAtLastSM(1);
            linkedListSM.AddNodeAtLastSM(2);
            linkedListSM.AddNodeAtLastSM(3);
            linkedListSM.AddNodeAtLastSM(4);
            
            //Print The linked List
            linkedListSM.PrintLinkedListSM();



            Console.ReadLine();
        }
    }
}
