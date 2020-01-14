using System;
using System.Collections;
using System.Collections.Generic;

namespace StackSM
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creating a new stack and populating it

            //StackSM stackSM = new StackSM(5);
            //stackSM.PushSm(1);
            //stackSM.PushSm(2);
            //stackSM.PushSm(3);
            //stackSM.PushSm(4);
            //stackSM.PushSm(5);
            //stackSM.PrintStackSM();

            #endregion


            #region Reverse string using stack

            //string s = "Hello world";
            //char[] c = s.ToCharArray();
            //StackSM stackSM = new StackSM(c.Length);
            //foreach (var item in c)
            //{
            //    stackSM.PushSm((int)item);
            //}
            //char[] reversed = new char[c.Length];
            //int i = 0;
            //while (stackSM.PeekSM() != int.MinValue)
            //{
            //    reversed[i++] = (char)stackSM.PopSm() ;
            //}
            //Console.WriteLine(new string(reversed));

            #endregion


            #region Reverse string using loop

            //string s = "Hello world";
            //char[] c = s.ToCharArray();
            //for (int i = 0; i < c.Length/2; i++)
            //{
            //    swap(ref c[i], ref c[c.Length - i - 1]);
            //}
            //Console.WriteLine(new String(c));

            #endregion


            #region Implement two stacks in an array

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

            #endregion


            #region Check for balanced parentheses in an expression

            //string s = Console.ReadLine();
            //char[] c = s.ToCharArray();
            //StackSM stackSM = new StackSM(c.Length);
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i] == '[' || c[i] == '(' || c[i] == '{')
            //    {
            //        stackSM.PushSm((int)c[i]);
            //    }
            //    else
            //    {
            //        char popped = (char)stackSM.PopSm();
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

            #endregion


            #region Next Greater Element

            //string s = Console.ReadLine();
            //int[] c = Array.ConvertAll(s.Split(' ').ToArray(), int.Parse);
            //StackSM stackSM = new StackSM(c.Length);
            //for (int i = 0; i < c.Length; i++)
            //{
            //    int elementToPush = c[i];
            //    if (stackSM.PeekSM() == int.MinValue)
            //    {
            //        stackSM.PushSm(elementToPush);
            //        continue;
            //    }
            //    while(stackSM.PeekSM() < elementToPush && stackSM.PeekSM()!=int.MinValue)
            //    {
            //        Console.WriteLine(stackSM.PopSm() + " -> " + elementToPush);
            //    }
            //    stackSM.PushSm(elementToPush);
            //}
            //while (stackSM.PeekSM() != int.MinValue)
            //{
            //    Console.WriteLine(stackSM.PopSm() + " -> -1");
            //}   

            #endregion


            #region Reverse a stack using recursion

            //StackSM stackSM = new StackSM(5);
            //stackSM.PushSm(1);
            //stackSM.PushSm(2);
            //stackSM.PushSm(3);
            //stackSM.PushSm(4);
            //stackSM.PushSm(5);
            //stackSM.ReverseAStackUsingRecursionSm();
            //stackSM.PrintStackSM();

            #endregion


            #region Sort a stack using recursion

            //StackSM stackSM = new StackSM(5);
            //stackSM.PushSm(1);
            //stackSM.PushSm(4);
            //stackSM.PushSm(2);
            //stackSM.PushSm(3);
            //stackSM.PushSm(5);
            //stackSM.SortAStackUsingRecursionSm();
            //stackSM.PrintStackSM();

            #endregion


            #region The Stock Span Problem

            //int[] price = { 10, 4, 5, 90, 120, 80 };
            //int length = price.Length;
            //int[] s = new int[length];
            //StockSpan(price, length, s);

            #endregion


            #region Sort a stack using a temporary stack

            //StackSM stackSM = new StackSM(4);
            //stackSM.PushSm(1);
            //stackSM.PushSm(4);
            //stackSM.PushSm(2);
            //stackSM.PushSm(3);
            //StackSM tempStack = stackSM.SortUsingTemp();
            //while (!tempStack.IsEmpty())
            //{
            //    Console.WriteLine(tempStack.PopSm());
            //}

            #endregion


            #region Delete array elements which are smaller than next or become smaller

            //int n = 5, k = 2;
            //int[] arr = { 20, 10, 25, 30, 40 };
            //DeleteElements(arr, n, k);



            #endregion


            #region Number of NGEs to the right

            //int[] a = { 3, 4, 2, 7, 5, 8, 10, 6 };
            //int t = CountNextContinuousGreater(a, 3);
            //int t1 = CountNextContinuousGreater(a, 6);
            //int t2 = CountNextContinuousGreater(a, 1);
            //Console.WriteLine(t);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);

            #endregion


            #region Delete middle element of a stack

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //DeleteMidElement(stack, stack.Count / 2);
            //Console.WriteLine();

            #endregion


            #region Find if an expression has duplicate parenthesis or not

            string str = "((a+b)+((c+d)))";

            if (!findDuplicateparenthesis(str))
            {
                Console.WriteLine("Duplicate Found ");
            }
            else
            {
                Console.WriteLine("No Duplicates Found ");
            }

            #endregion

            Console.ReadLine();



        }

        private static bool findDuplicateparenthesis(string str)
        {
            Stack stack = new Stack();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                {
                    stack.Push(str[i]);
                }
                else if(str[i] == ')' || str[i] == '}' || str[i] == ']')
                {
                    char c = (char)stack.Peek();
                    if ( c == '(' || c == '{' || c == '[')
                    {
                        return false;
                    }
                    
                    while(stack.Count>0 && c != '(' && c != '{' && c != '[')
                    {
                        c = (char)stack.Pop();
                    }
                    if (!DoTheyMatch(c, str[i]))
                    {
                        return false;
                    }
                   
                    

                }
                else
                {
                    stack.Push(str[i]);

                }
            }
            return true;
        }

       

        private static void DeleteMidElement(Stack<int> stack, int mid)
        {
            if (mid == 0)
            {
                stack.Pop();
                return;
            }
            int t = stack.Pop();
            DeleteMidElement(stack, --mid);
            stack.Push(t);
        }

        private static int CountNextContinuousGreater(int[] a, int index)
        {
            int elementAtIndex = a[index];
            if (index == a.Length - 1) return 0;
            Stack<int> stack = new Stack<int>();
            for (int i = index + 1; i < a.Length; i++)
            {
                if (stack.Count == 0 && elementAtIndex < a[i])
                    stack.Push(a[i]);
                else if (stack.Count > 0 && stack.Peek() < a[i])
                {
                    stack.Push(a[i]);
                }
            }
            return stack.Count;
        }

        private static void DeleteElements(int[] arr, int n, int k)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(arr[i]);
                    continue;
                }
                while (stack.Count > 0 && stack.Peek() < arr[i] && k-- > 0)
                {
                    stack.Pop();
                }
                stack.Push(arr[i]);
            }
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }



        private static void StockSpan(int[] price, int length, int[] s)
        {
            Stack stack = new Stack();
            stack.Push(0);
            for (int i = 1; i < length; i++)
            {
                while (stack.Count > 0 && price[(int)stack.Pop()] < price[i])
                {
                    stack.Pop();
                }

                s[i] = (stack.Count == 0) ? i + 1 : i - (int)stack.Peek();
                stack.Push(1);
            }
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
