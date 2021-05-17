using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek workDay = DayOfWeekParse("Monday, Tuesday");

            DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Sunday;

            //DayOfWeek workDay = DayOfWeek.Monday |
            //                    DayOfWeek.Tuesday | 
            //                    DayOfWeek.Wednesday | 
            //                    DayOfWeek.Thursday | 
            //                    DayOfWeek.Friday;

            Console.WriteLine(workDay);

            //intersectia lor           ==....
            bool isMonday = workDay.HasFlag(DayOfWeek.Monday);     // SAU    (workDay & DayOfWeek.Monday) == DayOfWeek.Monday;
            bool isTuesday = workDay.HasFlag(DayOfWeek.Tuesday);    //(workDay & DayOfWeek.Tuesday) == DayOfWeek.Tuesday;
            bool isWednesday = (workDay & DayOfWeek.Wednesday) == DayOfWeek.Wednesday;
            bool isThursday = (workDay & DayOfWeek.Thursday) == DayOfWeek.Thursday;
            bool isFriday = (workDay & DayOfWeek.Friday) == DayOfWeek.Friday;
            bool isSaturday = (weekend & DayOfWeek.Saturday)==DayOfWeek.Saturday;
            bool isSunday = (weekend & DayOfWeek.Sunday) == DayOfWeek.Sunday;

            Console.WriteLine($"Is Monday={isMonday}");
            Console.WriteLine($"Is Tuesday={isTuesday}");
            Console.WriteLine($"Is Wednesday={isWednesday}");
            Console.WriteLine($"Is Thursday={isThursday}");
            Console.WriteLine($"Is Friday={isFriday}");
            Console.WriteLine($"Is Saturday={isSaturday}");
            Console.WriteLine($"Is Sunday={isSunday}");

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

        public static bool IsWeekend(DayOfWeek day)
        {
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static DayOfWeek DayOfWeekParse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return DayOfWeek.None;
            }

            if(Enum.TryParse(typeof(DayOfWeek), value, out object result))
            {
                return (DayOfWeek)result;
            }
            else
            {
                return DayOfWeek.None;
            }

            //return (DayOfWeek)Enum.Parse(typeof(DayOfWeek), value); 
        }
    }
}
