using System;

namespace InputOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100: ");
            int enterNumber = int.Parse(Console.ReadLine());
            try
            {
                if (enterNumber < 1 || enterNumber > 100)
                {
                    throw new Exception("Number is not between 1 and 100!");
                }
                Console.WriteLine(enterNumber * enterNumber);
            }
            catch (OverflowException ex1)
            {

                Console.WriteLine("The number entered is too large or too small!");
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("Please enter an integer value!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally running!");
            }

            Console.WriteLine("Please enter a value between 1 and 6");
            int enterNumber2 = int.Parse(Console.ReadLine());

            if (1<enterNumber2 && enterNumber2<6)
            {
                Console.WriteLine(enterNumber2 * enterNumber2 * enterNumber2);
            }
            else
            {
                Console.WriteLine("Ohhhhhhh,enough man really?");
            }

        }
    }
}
