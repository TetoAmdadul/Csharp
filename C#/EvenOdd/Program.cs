using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if ( num % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else 
            {
                Console.WriteLine("This ia an odd number");
            }


            Console.ReadKey();
            
        }
    }
}
