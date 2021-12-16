using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //We call the data types that we can hold more than one value of the same type as arrays.
            //Index starts at zero

            int number = 0;
            int[] numbers = new[] { 1, 2, 3, 6, 69, 45 };
            numbers = new int[10];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 6;

            Console.WriteLine(numbers.Length);

            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(numbers[i]);
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            double[,] matrix = new double[5, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.NextDouble() * rnd.Next(100);
                    Console.WriteLine(matrix[i, j]);
                }
            }

            Array.Resize(ref numbers, 20);

            //ArrayList

            ArrayList list1 = new ArrayList();
            list1.Add(123);
            list1.Add("Kamil");
            list1.Add(true);
            list1.Add(null);
            list1.Add(DateTime.Now);
            list1.Add(matrix);
            Console.WriteLine(list1);

            //Generic List

            List<int> list2 = new List<int>();

            list2.Add(5);
            list2.Add(3);
            list2.Add(23);




        }
    }
}
