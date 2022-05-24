using System;

namespace Trapping_Rain_Water
{
    public static class Program
    {
        public static int Trap (int[] arr, int n)
        {
            int res = 0;
            for (int i = 1; i < n - 1; i++)
            {
                int left = arr[i];
                for (int j = 0; j < i; j++)
                {
                    left = Math.Max(left, arr[j]);
                }

                int right = arr[i];
                for (int j = i+1; j < n; j++)
                {
                    right = Math.Max(right, arr[j]);
                }
                res += Math.Min(left, right) - arr[i];
            }
            return res;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 4, 2, 0, 3, 2, 5 };
            int n = arr.Length;
            Console.Write(Trap(arr, n));
        }
    }
}
