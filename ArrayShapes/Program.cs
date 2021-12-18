using System;

namespace ArrayShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] matrix = null;
            try
            {
                Console.Write("Please enter the size: ");
                int enterSize = int.Parse(Console.ReadLine());
                matrix = new bool[enterSize, 2 * enterSize - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if ((line + column >= matrix.GetLength(0) - 1 && column - line <= matrix.GetLength(0) - 1))
                    {
                        matrix[line,column] = true;
                    }
                }
            }

            //write on screen
            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[line,column] ? "X" : " ");
                }
                Console.WriteLine();
            }

            Console.Write("Uzunluk: ");
            int sideLength = Convert.ToInt32(Console.ReadLine());
            int middlePoint = sideLength - 1;
            int floor = sideLength * 2 - 1;

            for (int i = 0; i < sideLength; i++)
            {
                for (int k = 0; k < floor; k++)
                {
                    if ((i + k >= middlePoint && k - i <= middlePoint))
                    {
                        Console.Write("*");
                    }
                    else if (i == middlePoint)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
