using System;
using System.Collections.Generic;

namespace Roman_to_Integer
{
    public static class Program
    {
        public static int RomanToInteger(string s)
        {
            int sum = 0;
            Dictionary<char, int> romandic = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                romandic.TryGetValue(c, out int n);
                if (i+1 < s.Length && romandic[s[i+1]] > romandic[c])
                {
                    sum -= n;
                }
                else
                {
                    sum += n;
                }
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            
        }
    }
}
