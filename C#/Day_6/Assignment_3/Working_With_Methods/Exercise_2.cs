namespace Day2
{
    internal class Program
    {
        static int Fibonacci(int a)
        {
            if (a < 3)
            {
                return 1;
            }

            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
        static void Main(string[] args)
        {
            int number = Fibonacci(3);
            Console.WriteLine(number);

        }
    }
}
