using System;

namespace Longest_Palindromic_Substring
{
    public class Program
    {
        public static string LongestPalindrome(string s)
        {
            int maxLength = 0, startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int start = i, end = i;
                while (end < s.Length - 1 && s[start] == s[end + 1])
                    end++;

                while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                if (maxLength < end - start + 1)
                {
                    maxLength = end - start + 1;
                    startIndex = start;
                }
            }
            return s.Substring(startIndex, maxLength);
        }
        static void Main(string[] args)
        {
            string s = "bababaad";
            Console.Write(LongestPalindrome(s));
        }
    }
}
