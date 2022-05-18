namespace Day2
{
    internal class Program
    {
        static int[] GenerateNumbers(int n=10)
        {
            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = i+1;
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

