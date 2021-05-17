using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            //DayOfWeek day = GetDayOfWeek(125);
            DayOfWeek day = (DayOfWeek)125;

            switch (day)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("You need to work!!!!");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("You are in weekend, enjoy");
                    break;

                default:
                    Console.WriteLine($"{day} does not represent a valid value of the {typeof(DayOfWeek)}");
                    break;
            }
            Console.WriteLine(day);


            Console.WriteLine((int)DayOfWeek.Monday);
            Console.WriteLine((int)DayOfWeek.Tuesday);
            Console.WriteLine((int)DayOfWeek.Wednesday);
            Console.WriteLine((int)DayOfWeek.Thursday);
            Console.WriteLine((int)DayOfWeek.Friday);
            Console.WriteLine((int)DayOfWeek.Saturday);
            Console.WriteLine((int)DayOfWeek.Sunday);
        }


        public static DayOfWeek GetDayOfWeek(int day)
        {
            if (Enum.IsDefined(typeof(DayOfWeek), day))
            {
                //true, when day represents a valid label
                return (DayOfWeek)day;
            }
            else
            {
                throw new ArgumentException($"{day} does not represent a valid value of the {typeof(DayOfWeek)}");
            }
        }
    }
}
