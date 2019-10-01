using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSM
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Creating a new stack and populating it
            //StackSM stackSM = new StackSM(5);
            //stackSM.PushSM(1);
            //stackSM.PushSM(2);
            //stackSM.PushSM(3);
            //stackSM.PushSM(4);
            //stackSM.PushSM(5);
            //stackSM.PrintStackSM();



            ////reverse string using stack
            //string s = "Hello world";
            //char[] c = s.ToCharArray();
            //StackSM stackSM = new StackSM(c.Length);
            //foreach (var item in c)
            //{
            //    stackSM.PushSM((int)item);
            //}
            //char[] reversed = new char[c.Length];
            //int i = 0;
            //while (stackSM.PeekSM() != int.MinValue)
            //{
            //    reversed[i++] = (char)stackSM.PopSM() ;
            //}
            //Console.WriteLine(new string(reversed));




            ////reverse string using loop
            //string s = "Hello world";
            //char[] c = s.ToCharArray();
            //for (int i = 0; i < c.Length/2; i++)
            //{
            //    swap(ref c[i], ref c[c.Length - i - 1]);
            //}
            //Console.WriteLine(new String(c));



            ////Implement two stacks in an array
            //TwoStackSM twoStackSM = new TwoStackSM(7);
            //twoStackSM.Push1SM(1);
            //twoStackSM.Push1SM(2);
            //twoStackSM.Push1SM(3);
            //twoStackSM.Push2SM(4);
            //twoStackSM.Push2SM(5);
            //twoStackSM.Push2SM(10);
            //twoStackSM.Push2SM(12);
            //twoStackSM.PrintStack1SM();
            //twoStackSM.PrintStack2SM();



            ////Check for balanced parentheses in an expression
            //string s = Console.ReadLine();
            //char[] c = s.ToCharArray();
            //StackSM stackSM = new StackSM(c.Length);
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i] == '[' || c[i] == '(' || c[i] == '{')
            //    {
            //        stackSM.PushSM((int)c[i]);
            //    }
            //    else
            //    {
            //        char popped = (char)stackSM.PopSM();
            //        bool t = DoTheyMatch(popped, c[i]);
            //        if (t == false)
            //        {
            //            Console.WriteLine("Not balanced");
            //            Console.ReadLine();
            //            return;
            //        }
            //    }
            //}
            //Console.WriteLine("Balanced");




            //Next Greater Element
            string s = Console.ReadLine();
            int[] c = Array.ConvertAll(s.Split(' ').ToArray(), int.Parse);
            StackSM stackSM = new StackSM(c.Length);
            for (int i = 0; i < c.Length; i++)
            {
                int elementToPush = c[i];
                if (stackSM.PeekSM() == int.MinValue)
                {
                    stackSM.PushSM(elementToPush);
                    continue;
                }
                while(stackSM.PeekSM() < elementToPush && stackSM.PeekSM()!=int.MinValue)
                {
                    Console.WriteLine(stackSM.PopSM() + " -> " + elementToPush);
                }
                stackSM.PushSM(elementToPush);
            }
            while (stackSM.PeekSM() != int.MinValue)
            {
                Console.WriteLine(stackSM.PopSM() + " -> -1");
            }   

            Console.ReadLine();



        }

        private static bool DoTheyMatch(char popped, char v)
        {
            if (popped == '[' && v == ']')
            {
                return true;
            }
            if (popped == '{' && v == '}')
            {
                return true;
            }
            if (popped == '(' && v == ')')
            {
                return true;
            }
            return false;

        }

        private static void swap(ref char v1, ref char v2)
        {
            char temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
