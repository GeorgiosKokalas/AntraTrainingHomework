namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            } else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            } else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 23)
            {
                Console.WriteLine("Good Evening");
            } else if (DateTime.Now.Hour <= 7)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
