//I NEED TO GET BACK TO THIS
namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            // int[] arr = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
            Array.Sort(arr);
            int num = arr[0];
            int amount = 1;
            int finam = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    amount++;
                    if (amount > finam)
                    {
                        finam = amount;
                        num = arr[i - 1];
                    }
                }
                else
                {
                    amount = 1;
                }
            }
            Console.WriteLine("The number " + num + " is most frequent by appearing " + finam + " times.");
        }
    } 
}
