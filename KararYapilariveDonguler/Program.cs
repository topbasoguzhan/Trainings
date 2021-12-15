using System;

namespace KararYapilariveDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            if (tarih.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Monday");
            }
            else if(tarih.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Sunday");
            }
            else if(tarih.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Saturday");
            }
            if(tarih.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Friday");
            }
            if
        }
    }
}
