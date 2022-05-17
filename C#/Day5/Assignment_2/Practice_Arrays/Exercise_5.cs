//I NEED TO GET BACK TO THIS
namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int Length1 = 0;
            int Length2 = 1;
            
            // int[] init = {1,1,1,2,3,1,3,3 };
            int[] init = { 4, 4, 4, 4 };
            num = init[0];
            for (int i = 1; i < init.Length; i++)
            {
                if (init[i] == init[i - 1]) {
                    Length2++;
                } else if (init[i] != init[i - 1] && Length2 > Length1)
                {
                    num = init[i - 1];
                    Length1 = Length2;
                    Length2 = 0;
                }
            }

            if (Length1 == 0) { Length1 = Length2;}
            
            int[] result = new int[Length1];
            for (int o = 0; o < Length1; o++){result[o] = num;}
            
            foreach (int i in result) {Console.WriteLine(i);}

        }
    } 
}
