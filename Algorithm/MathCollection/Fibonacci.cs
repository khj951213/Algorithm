using System;
namespace MathCollection
{
    public class Fibonacci
    {
        public static int FibonacciSum(int a)
        {
            if (a < 2)
            {
                return a;
            }
            else
            {
                return FibonacciSum(a - 1) + FibonacciSum(a - 2);
            }
        }
    }
}

