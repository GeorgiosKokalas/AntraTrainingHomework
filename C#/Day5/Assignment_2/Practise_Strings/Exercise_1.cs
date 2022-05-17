namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Input:");
            string input = Console.ReadLine();
            char[] input_arr = input.ToCharArray();
            int length = input_arr.Length;
            char[] input_arr1 = new char[length];
            for (int i = 0; i < length; i++)
            {
                input_arr1[length - 1 - i] = input_arr[i];
            }

            string new_input =new string(input_arr1);
            Console.WriteLine(new_input);
            
            for (int i = input.Length-1; i >=0; i--)
            {
                Console.Write(input[i]);
            }
        }
    } 
}
