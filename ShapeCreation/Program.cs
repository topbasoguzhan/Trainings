using System;

namespace ShapeCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Square");
            Console.WriteLine("2: Empty Square");
            Console.WriteLine("3: Triangle");
            Console.WriteLine("Please, make a choice...");
            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.D1 || info.Key == ConsoleKey.NumPad1)
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
                                if (line == 0 || column == 0 || line == column - 1 || column == line - 1)
                                    Console.WriteLine("X");
                                else
                                    Console.WriteLine(" ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    }
                    catch
                    {
                        Console.WriteLine("You made a wrong entry!");
                    }

                } while (true);//breakpointle içi boş karenin çalışmasını da incele.
            }
        }
    }
}
