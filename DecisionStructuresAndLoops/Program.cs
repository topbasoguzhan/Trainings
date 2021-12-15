using System;

namespace DecisionStructuresAndLoops
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
            else if (tarih.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Sunday");
            }
            else if (tarih.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Saturday");
            }
            else if (tarih.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Friday");
            }
            else if (tarih.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("Thursday");
            }
            else if (tarih.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Tuesday");
            }
            else if (tarih.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Wednesday");
            }

            DayOfWeek haftaninGunu = tarih.DayOfWeek;

            string sonuc = "";
            switch (haftaninGunu)
            {
                case DayOfWeek.Monday:
                    sonuc = "Monday";
                    break;
                case DayOfWeek.Tuesday:
                    sonuc = "Tuesday";
                    break;
                case DayOfWeek.Wednesday:
                    sonuc = "Wednesday";
                    break;
                case DayOfWeek.Thursday:
                    sonuc = "Thursday";
                    break;
                case DayOfWeek.Friday:
                    sonuc = "Friday";
                    break;
                case DayOfWeek.Saturday:
                    sonuc = "Saturday";
                    break;
                case DayOfWeek.Sunday:
                    sonuc = "Sunday";
                    break;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();

            //donguler
            //while

            int counter = 0; int numberOfDays = 0;
            while (numberOfDays < 100)
            {
                DateTime nextDay = tarih.AddDays(counter);
                counter++;
                if (nextDay.DayOfWeek == DayOfWeek.Sunday || nextDay.DayOfWeek == DayOfWeek.Saturday)
                    continue;
                numberOfDays++;
                Console.WriteLine(nextDay);
                break;
            }
            Console.Clear();

            counter = 0; numberOfDays = 0;
            do
            {
                DateTime nextDay = tarih.AddDays(counter);
                counter++;
                if (nextDay.DayOfWeek == DayOfWeek.Sunday || nextDay.DayOfWeek == DayOfWeek.Saturday)
                    continue;
                numberOfDays++;

                Console.WriteLine(nextDay);
                break;

            } while (numberOfDays < 100);

            //break continue return

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
