namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1999, 12, 14);
            DateTime today = DateTime.Today;

            TimeSpan difference = today.Subtract(birthdate);
            int days = difference.Days;
            Console.WriteLine($"You are {days} days old");
            Console.WriteLine($"You are {10000 - (days % 10000)} days away from your 10000th day anniversary");
        }
    }
}
