using System;

namespace ShapeCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1: Square");
                Console.WriteLine("2: Empty Square");
                Console.WriteLine("3: Triangle");
                Console.WriteLine("Please, make a choice...");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.D1 || info.Key == ConsoleKey.NumPad1)
                {
                    do//full cycle
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter the side length of the square: ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int line = 0; line < value; line++)
                            {
                                for (int column = 0; column < value; column++)
                                {
                                    Console.Write("X");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("You made a wrong entery!");
                        }

                    } while (true);
                }
                else if (info.Key == ConsoleKey.D2 || info.Key == ConsoleKey.NumPad2)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter the side length of the square: ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int line = 0; line < value; line++)
                            {
                                for (int column = 0; column < value; column++)
                                {
                                    if (line == 0 || column == 0 || line == value - 1 || column == value - 1)
                                        Console.Write("X");
                                    else
                                        Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;

                        }
                        catch
                        {
                            Console.WriteLine("You made a wrong entry!");
                        }

                    } while (true);
                }
                else if (info.Key == ConsoleKey.D3 || info.Key == ConsoleKey.NumPad3)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter the height of the triangle: ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int line = 0; (line < value); line++)
                            {
                                for (int column = 0; column < value + line; column++) //n+0 n+1 n+2
                                {
                                    if (value > column + line + 1)//n-2 n-1 n-0
                                        
                                        Console.Write(" ");
                                    else
                                        Console.Write("X");
                                }
                                Console.WriteLine();
                            }
                            break;

                        }
                        catch
                        {
                            Console.WriteLine("You made a wrong entry!");
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You made a wrong choice!");
                    continue;
                }
                //Do you wanna play again?
                Console.WriteLine();
                Console.WriteLine("Do you want to draw again?");
                info = Console.ReadKey();
                if (info.Key != ConsoleKey.Y)
                    break;
            } while (true);
            Console.WriteLine();
            Console.WriteLine("You can close the program. Have a nice day :) ");
        }
    }
}
