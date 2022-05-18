namespace Day2
{
    internal class Program
    {
        static int[] GenerateNumbers()
        {
            Console.WriteLine("Give Input:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            int[] result = new int[numbers.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }

            return result;
        }

        static void Reverse(int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
            }
            
            b.CopyTo(a,0);
        }

        static void PrintNumbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("\n");
        }
        
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
            
        }
    }
}
