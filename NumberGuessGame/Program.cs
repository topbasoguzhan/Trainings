using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do//one game circle.
            {
                Random rnd = new Random();
                int guessNumber = 0, randomNumber = rnd.Next(1, 101), entry = 0;
                do
                {
                    Console.WriteLine("Guess random number: ");
                    try
                    {
                        entry = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("You made a wrong expression!");
                        continue;
                    }
                    finally
                    {
                        guessNumber++;
                    }

                    if (entry == randomNumber)
                    {
                        Console.WriteLine($"Congratulations! You finished {guessNumber}. try :)");
                        break;
                    }
                    else if (entry > randomNumber)
                    {
                        Console.WriteLine("Lower your guess...");
                    }
                    else
                    {
                        Console.WriteLine("Higher your guess...");
                    }
                } while (true);
                Console.WriteLine("Press Y to play again. If you don't want just press any button :D!");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.Y)
                    break;
            } while (true);
        }
    }
}
