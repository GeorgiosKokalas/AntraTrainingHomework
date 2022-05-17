namespace Day1
{
    internal class Program
    {
        static int GetIndex(int a, int max)
        {
            if (a < 0)
            {
                return GetIndex(max + a, max);
            }

            return a;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();
            string[] stringint = input.Split(" ");
            int[] init = new int[stringint.Length];
            for (int i = 0; i < stringint.Length; i++)
            {
                init[i] = int.Parse(stringint[i]);
            }
            
            Console.WriteLine("Input2:");
            int rotations = int.Parse(Console.ReadLine());
            int[][] keepers = new int[rotations][];

            int[] result = new int[init.Length];
            for (int i = 0; i < init.Length; i++)
            {
                result[i] = 0;
                for (int o=1; o <= rotations; o++)
                {
                    result[i] += init[GetIndex(i - o, init.Length)];
                }
            }
            
            foreach(int i in result){Console.WriteLine(i);}
        }
    } 
}
