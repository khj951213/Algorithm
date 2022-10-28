namespace Fibonacci
{
    public class Fibo
    {

        public static int GetFibo(int a)
        {
            if (a < 2)
            {
                return a;
            }
            else
            {
                return GetFibo(a - 1) + GetFibo(a - 2);
            }
        }

    }
}

