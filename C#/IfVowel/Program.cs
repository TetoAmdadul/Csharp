using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.Write("input the letter: ");
            
            letter = Convert.ToChar(Console.ReadLine());
            letter = char.ToLower(letter);

            if ((letter >= 'a' && letter <= 'z') && (letter == 'a' || letter == 'e' || 
                                       letter == 'i' || letter == 'o' || letter == 'u'))
            {
                Console.WriteLine("It is a vowel");

            }
            else if ((letter >= 'a' && letter <= 'z') &! (letter == 'a' || 
                       letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'))
            {
                Console.WriteLine("It is a consonant");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
