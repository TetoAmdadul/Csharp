using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.WriteLine("please enter the day name: ");
            day = Console.ReadLine();


            switch (day.ToLower()) 
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thrusday":
                case "friday":
                    Console.WriteLine("It is weekday");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("It is weekend");
                    break;
                    default:
                    Console.WriteLine("It is an invalid dayname");
                    break;

            }
        }
    }
}
