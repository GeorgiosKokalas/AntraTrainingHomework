namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            int centuries;
            Console.WriteLine("");
            if (Int32.TryParse(input, out centuries))
            {
                int years = centuries * 100;
                int days = years * 365;
                int hours = days * 24;
                ulong minutes = (ulong)hours * 60;
                ulong seconds = minutes * 60;
                ulong milliseconds = seconds * 1000;
                ulong microseconds = milliseconds * 1000;
                ulong nanoseconds = microseconds * 1000;

                Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds );
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
