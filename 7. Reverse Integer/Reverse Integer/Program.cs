using System;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be reversed: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            if (x < 10)
                Console.WriteLine("The number must has at least two digit. Try again!");
            else
            {
                while (x != 0)
                {
                    rem = x % 10;
                    reverse = reverse * 10 + rem;
                    x /= 10;
                }

                Console.WriteLine("The reversed number is: " + reverse);
            }
        }
    }
}
