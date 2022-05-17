namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%3 == 0){Console.Write("Fizz");}
                if (i%5 == 0){Console.Write("Buzz");}
                if (i%3 != 0 && i%5 !=0){Console.Write(i);}
                Console.Write("\n");
            }
            
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
                if (i == Byte.MaxValue)
                {
                    break;
                }
            }

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
