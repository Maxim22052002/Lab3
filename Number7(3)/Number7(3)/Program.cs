using System;

namespace Number7_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the element of the fibonacci series: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N+" element of the fibonacci series: ");
            Console.WriteLine(FibonacciRecursive(N));
        }
        static long FibonacciRecursive(int n)
        {
            

            if (n == 0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
