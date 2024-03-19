using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2;
            Console.Write("Type the value of number 1: ");
            numb1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type the value of number 2: ");
            numb2 = Convert.ToInt32(Console.ReadLine());

            if (numb1 < numb2)
            {
                Console.WriteLine($"{numb1} is smaller than {numb2}");
            }
            else if(numb2 < numb1) 
            {
                Console.WriteLine($"{numb2} is smaller than {numb1}"); 
            }
            else
            {
                Console.WriteLine($"{numb2} and {numb2} numbers are eqal numbers");
            }
        }
    }
}
