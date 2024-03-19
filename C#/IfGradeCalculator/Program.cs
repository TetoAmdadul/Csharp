using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int totalNumber;
             Console.Write("input the totalnumber: ");
             totalNumber = Convert.ToInt32(Console.ReadLine());

             if (totalNumber < 0)
             {
                 Console.WriteLine("Invalid input ");
             }
             else if (totalNumber > 0 && totalNumber < 60)
             {
                 Console.WriteLine("Your grade is F ");
             }
             else if (totalNumber >= 60 && totalNumber < 70 )
             {
                 Console.WriteLine("Your grade is D ");
             }
             else if (totalNumber >= 70 && totalNumber < 80)
             {
                 Console.WriteLine("Your grade is C ");
             }
             else if (totalNumber >= 80 && totalNumber < 90)
             {
                 Console.WriteLine("Your grade is B ");
             }
             else if (totalNumber >= 89 && totalNumber <= 100)
             {
                 Console.WriteLine("Your grade is A ");
             }
             else 
             {
                 Console.WriteLine("Total number cannot exceds 100 ");
             }*/
            double marks;
            Console.Write("Input your marks for checking your grade: ");
            marks = double.Parse(Console.ReadLine());   

            if (marks >= 0 && marks <= 100)
            {
                
                if (marks >= 90)
                {
                    Console.WriteLine($"Congratulations, You got A grade with {marks} points");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine($"Congratulations, You got B grade with {marks} points");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine($"Congratulations, You got C grade with {marks} points");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine($"Congratulations, You got D grade with {marks} points");
                }
                else
                {
                    Console.WriteLine($"Unfortunately, You got F grade with {marks} points. Try again for better grade");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");

            }
        }
    }
}
