using System;

namespace MethodUsage2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ref and out
            int a = 5;
            RefMethod(ref a);
            if (TryToConvert("123",out int answer))
            {
                Console.WriteLine(answer);
            }
            Tuple<bool, int> tuple = TryToConvert("32423");
            if (tuple.Item1)
            {
                Console.WriteLine(tuple.Item2);
            }


        }

        static Tuple<bool, int> TryToConvert(string expression)
        {
            try
            {
                int result = int.Parse(expression);
                return new Tuple<bool,int>(true, result);
            }
            catch
            {
                return new Tuple<bool,int>(false, 0);
            }
        }

        static bool TryToConvert(string expression, out int result)
        {
            try
            {
                result = int.Parse(expression);
                return true;
            }
            catch
            {
                result=0;
                return false;
            }           
        }
        static void RefMethod(ref int a)
        {
            int b = 10;
            a = b;
            b = 20;
        }
    }
}
