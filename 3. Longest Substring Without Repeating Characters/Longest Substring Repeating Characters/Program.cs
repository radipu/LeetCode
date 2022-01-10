using System;

namespace Longest_Substring_Repeating_Characters
{
    public static class Program
    {
        static int longestUniqueSubsttr(string str)
        {
            int n = str.Length;
            int res = 0;

            for (int i = 0; i < n; i++)
            {
                bool[] visited = new bool[256];
                for (int j = i; j < n; j++)
                {
                    if (visited[str[j]] == true)
                        break;
                    else
                    {
                        res = Math.Max(res, j - i + 1);
                        visited[str[j]] = true;
                    }
                }

                visited[str[i]] = false;
            }
            return res;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine("The input string is " + str);

            int len = longestUniqueSubsttr(str);
            Console.WriteLine("The length of the longest " +
                              "non-repeating character " +
                              "substring is " + len);
        }
    }
}
