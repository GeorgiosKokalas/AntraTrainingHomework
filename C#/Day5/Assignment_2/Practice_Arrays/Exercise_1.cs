namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 1, 2, 4, 1, 4, 12, 4, 9 };
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
