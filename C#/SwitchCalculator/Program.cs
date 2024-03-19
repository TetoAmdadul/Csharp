using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            char operation;

            Console.Write("input the number1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input the operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("input the number2: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{number1} + {number2}  =  { number1 + number2}");
                    break;


                case '-':
                    Console.WriteLine($"{number1} - {number2}  =  {number1 - number2}");
                    break;

                case '*':
                    Console.WriteLine($"{number1} * {number2}  =  {number1 * number2}");
                    break;

                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{number1} / {number2}  =  {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("It is an error");
                    }
                   
                    break;

                default: 
                    Console.WriteLine("This is an invalid opertion");
                    break;
            }
        }
    }
}
