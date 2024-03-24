using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Give me the first number of series: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Give me the last number of series: ");
            int lastNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Give me the difference of the series: ");
            int differenceBetween = Convert.ToInt32(Console.ReadLine());


            //for (intializer; condition; update)
            //for (int i = 0;  i < 5;     i++)

            int sum = 0;
            for   (int i = firstNumber;    i < lastNumber;     i = i + differenceBetween)


            {
               sum = sum + i;
            }
            Console.WriteLine($"sum = {sum}");

        }
    }
}
