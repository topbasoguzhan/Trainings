using System;
using System.Collections.Generic;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int life = 5, known = 0;
                string[] questions = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                string selectedQuestion = questions[new Random().Next(questions.Length)];
                double score = selectedQuestion.Length * 100;
                char[] screen = new char[selectedQuestion.Length];
                Console.Clear();
                for (int i = 0; i < selectedQuestion.Length; i++)
                {
                    screen[i] = '-';
                }

                List<char> previousPredictions = new List<char>();

                do
                {
                    //write on screen
                    foreach (char character in screen)
                    {
                        Console.Write(character + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{score:#.00} score. {life} left alive");
                    Console.WriteLine("Guess: ");
                    string guess = Console.ReadLine();
                    bool isitRight = false;
                    if (!string.IsNullOrEmpty(guess) && guess.Length == 1) //character guess
                    {
                        char character = guess.ToLower()[0];
                        bool isitLeft = previousPredictions.Contains(character);
                        if (!isitLeft)
                        {
                            for (int i = 0; i < selectedQuestion.Length; i++)
                            {
                                if (selectedQuestion[i] == character)
                                {
                                    previousPredictions.Add(character);
                                    isitRight = true;
                                    screen[i] = character;
                                    known++;
                                }
                            }
                        }
                    }
                    else if (!string.IsNullOrEmpty(guess))
                    {
                        if (selectedQuestion == guess.ToLower())
                        {
                            isitRight = true;
                            break;
                        }
                    }
                    if (!isitRight)
                    {
                        life--;
                        score *= 0.85;
                        if (life == 0)
                        {
                            break;
                        }
                    }
                    if (selectedQuestion.Length == known)
                    {
                        break;
                    }

                } while (true);

                if (life ==0)
                {
                    Console.WriteLine("You lost! Score:0");
                }
                else
                {
                    Console.WriteLine(selectedQuestion);
                    Console.WriteLine($"Congratulations, you won! Your score: {score:#.00} Remaining life: {life}");
                }
                Console.WriteLine("Press Y to play again. If you don't want press N.");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.Y)
                    break;
            } while (true);
        }
    }
}
