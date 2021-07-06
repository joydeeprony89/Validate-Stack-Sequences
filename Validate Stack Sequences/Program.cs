using System;
using System.Collections.Generic;

namespace Validate_Stack_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var pushed = new int[5] { 1, 2, 3, 4, 5 };
            var popped = new int[5] { 4, 5, 3, 2, 1 };
            //var popped = new int[5] { 4, 5, 3, 1, 2 }; // incorrect sequence
            Console.WriteLine(Validate(pushed, popped));
        }

        static bool Validate(int[] a, int[] b)
        {
            Stack<int> stk = new Stack<int>();
            int j = 0;
            foreach(int i in a)
            {
                stk.Push(i);
                while (stk.Count > 0 && j < b.Length && b[j] == stk.Peek())
                {
                    stk.Pop();
                    j++;
                }
            }

            return stk.Count == 0;
        }
    }
}
