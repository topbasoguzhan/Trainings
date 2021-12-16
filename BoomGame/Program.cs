using System;

namespace BoomGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boom Game
            int numberOfBooms = 5, limit = 15;
            do//1 game cycle
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Please enter a number between from 1-50 for BOOM game: ");
                        numberOfBooms = int.Parse(Console.ReadLine());
                        if (numberOfBooms < 1 || numberOfBooms > 50)
                            throw new Exception("You didn't enter between from 1-50!");
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter a NUMBER!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }//get the appropriate number

                } while (true);
                for (int i = 1; i <= limit; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("Computer: ");
                        if (i % numberOfBooms == 0)
                            Console.WriteLine("BOOM");
                        else
                            Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("User: ");
                        string enter = Console.ReadLine();
                        if (i % numberOfBooms == 0)
                        {
                            if(enter.ToLower() != "boom")
                            {
                                Console.WriteLine("You lost :(");
                                break;
                            }
                        }//When you should enter the 'boom'
                        else
                        {
                            try
                            {
                                int enterNumber = int.Parse(enter);
                                if (enterNumber != i)
                                {
                                    Console.WriteLine("YOU LOST :(");
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine("You made a wrong entry!");
                                Console.WriteLine("YOU LOST! :(");
                                break ;
                            }
                        }//When you have to enter a number
                    }//set the user's order

                    if (i == limit)
                        Console.WriteLine("Congratulations! You tied :O ");
                }
                Console.WriteLine("Press Y to play again: ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.Y)
                    Console.WriteLine();
                    Console.WriteLine("Thank you for playing,have a nice day <3");
                break;
            } while (true);
        }
    }
}
