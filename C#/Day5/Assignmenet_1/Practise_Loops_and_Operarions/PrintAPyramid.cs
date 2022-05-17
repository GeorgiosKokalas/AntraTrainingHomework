namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int o = 0; o < 6 - i; o++)
                {
                    Console.Write(" ");
                }

                for (int o = 0; o < 2*i -1; o++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
