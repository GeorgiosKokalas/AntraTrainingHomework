namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int o = 1; o <= 4; o++)
            {
                for (int i = 0; i <= 24;)
                {
                    Console.Write($"{i},");
                    i += o;
                }
                Console.Write("\n");
            }
        }
    }
}
