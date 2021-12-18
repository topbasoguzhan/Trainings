using System;
using System.Collections.Generic;

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int life = 5, known = 0;
                string[] questions = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                string[] selectedQuestion = questions[new Random().Next(questions.Length)];
                double score = selectedQuestion.Length * 100;
                char[] screen = new char[selectedQuestion.Length];
                Console.Clear();
                for (int i = 0; i < questions.Length; i++)
                {
                    screen[i] = '-';
                }

                List<char> previousPredictions = new List<char>();

                do
                {
                    //write on screen
                    foreach (char character in screen)
                    {
                        Console.WriteLine(character + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{score:#.00} score.{life} left alive");
                    Console.WriteLine("Guess: ");
                    string guess = Console.ReadLine();
                    bool isitRight = false;
                    if )
                    {

                    }

                } while (true);
            } while (true);
        }
    }
}
