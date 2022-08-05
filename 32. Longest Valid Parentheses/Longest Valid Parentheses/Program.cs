using System;
using System.Collections.Generic;

namespace Longest_Valid_Parentheses
{
    public static class Program
    {
        public static int LongestValidParentheses(string s)
        {
            int n = s.Length;
            Stack<int> stk = new Stack<int>();
            stk.Push(-1);
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                {
                    stk.Push(1);
                }

                else
                {
                    if (stk.Count > 0)
                        stk.Pop();
                    if (stk.Count > 0)
                    {
                        result = Math.Max(result, i - stk.Peek());
                    }

                    else
                        stk.Push(i);
                }
            }
            return result;

            //int n = s.Length;
            //Stack<int> stk = new Stack<int>();
            //stk.Push(-1);
            //int result = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (s[i] == '(')
            //    {
            //        stk.Push(1);
            //    }

            //    else
            //    {
            //        if (stk.Count > 0)
            //            stk.Pop();
            //        if (stk.Count > 0)
            //        {
            //            result = Math.Max(result, i - stk.Peek());
            //        }

            //        else
            //            stk.Push(i);
            //    }
            //}
            //return result;
        }
        public static void Main(string[] args)
        {
            string s = "(()";
            Console.WriteLine(LongestValidParentheses(s));
        }
    }
}
