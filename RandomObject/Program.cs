using System;

namespace RandomObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //instance

            //a random number from 0-100
            int number1 = rnd.Next(0, 100);
            number1 = rnd.Next(0, 100);

            //a random number from -10-20
            int number2 = rnd.Next(-10, 20);
            number2 = rnd.Next(-10, 20);

            //a random number
            int number3 = rnd.Next();

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.ReadLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rnd.Next(1,50));
            }
        }
    }
}
