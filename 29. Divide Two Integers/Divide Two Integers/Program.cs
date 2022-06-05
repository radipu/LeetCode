using System;

namespace Divide_Two_Integers
{
    public static class Program
    {
        public static int Divide(int dividend, int divisor)
        {
            int sign = ((dividend < 0) ^
                (divisor < 0)) ? -1 : 1;
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);
            int quotient = 0;
            while (dividend >= divisor)
            {
                dividend -= divisor;
                ++quotient;
            }
            if (sign == -1) quotient = -quotient;
            return quotient;
        }
        static void Main(string[] args)
        {
            int a = 7;
            int b = -3;
            Console.WriteLine(Divide(a, b));
        }
    }
}
