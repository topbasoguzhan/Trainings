using System;

namespace MethodUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method
            //Will it return value? If no, we can use void. If yes, we should write the type that will be.
            //If the return type is typed, the return statement will be returned with the return keyword.
            //We have to name this method. PascalCase
            //Does this method need parameters while running? If no, it will be left blank. If yes, each parameter will be defined individually.
            Console.WriteLine("These results are fieldCalculation methods results.");
            Console.WriteLine();
            double field = FieldCalculation(5);
            Console.WriteLine("Field of square: " + field);
            
            field = FieldCalculation(3, 4);
            Console.WriteLine("Field of rectangle: " + field);
            
            field = FieldCalculation(5d);
            Console.WriteLine("Field of circle: " + field);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("There results are Add methods results.");
            int result = Add(Add(3, 5), 5) + Add(9, 7);
            Console.WriteLine(result);
            
            int[] numbers = { 3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5 };
            result = Add(new[] { 3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5 }, 1);
            Console.WriteLine(result);
            result = Add(numbers, 1);
            Console.WriteLine(result);
            result = Add(3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5);
            Console.WriteLine(result);
            Console.ReadLine();




        }
        ///<summary>
        ///Method for calculating area of square
        ///</summary>
        ///<param name="side"></param>One side length of square</param>
        ///<returns>Field of the square</returns>
        static double FieldCalculation(int side)
        {
            double result = side * side;
            return result;
        }
        /// <summary>
        /// Method for calculating are of rectangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns></returns>
        static double FieldCalculation(int side1, int side2)
        {
            return side1 * side2;
        }

        static double FieldCalculation(double r, double pi = Math.PI)
        {
            return r * r * pi;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int[] numbers, int rounding)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
        
        static int Add(double rounding, params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
