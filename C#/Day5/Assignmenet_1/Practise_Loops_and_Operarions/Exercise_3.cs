namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.Write("Guess a Number between 1 and 3: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess < correctNumber) {Console.WriteLine("Too low");}
            else if (guess > correctNumber) {Console.WriteLine("Too high");}
            else {Console.WriteLine("Correct!");}
            Console.WriteLine(correctNumber);
        }
    }
}
