namespace Day1
{
    internal class Program
    {
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] result = new int[0];
            for (int i = startNum; i < endNum; i++)
            {
                bool isPrime = true;
                if (i == 0 || i == 1) {isPrime = false;}
                for (int o = 2; o < i; o++){if (i % o == 0){isPrime = false;}}

                if (isPrime)
                {
                    int[] result2 = new int[result.Length + 1];
                    result.CopyTo(result2,0);
                    result2[result2.Length - 1] = i;
                    result = result2;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] i = FindPrimesInRange(1, 10);
            for (int o = 0; o < i.Length; o++)
            {
                Console.WriteLine(i[o]);
            }
        }
    } 
}
