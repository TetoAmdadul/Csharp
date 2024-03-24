using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int number = 1;

            while (true)
            {
                Console.WriteLine("Give a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 42)
                {
                    break;
                }
                number = number + 1;
            }
            Console.WriteLine();












            /***********************************************Exercise035**********************

           *********************************************************************************/
            /***********************************************Exercise035**********************

           *********************************************************************************/
            /***********************************************Exercise034**********************
             
              namespace Exercise034
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      
      while (true) 
{
    Console.WriteLine("Do you want to continue?");
    string input = Console.ReadLine();
    if (input == "no") 
    {
        break;
    }

}
Console.WriteLine();

    }
  }
}
            *********************************************************************************/

            /***********************************************Exercise*********************
              using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int readNumbers = 0;

            while (true)
            {
                if (readNumbers == 7)
                {
                    break;
                }

                Console.WriteLine("Give a number");
                sum = sum + Convert.ToInt32(Console.ReadLine());
                readNumbers = readNumbers + 1;
            }
            Console.WriteLine("Sum is " + sum);
            *********************************************************************************/
            /***********************************************Exercise033**********************
              Console.WriteLine("Give the first string:");
       string voice1 = Console.ReadLine();
        Console.WriteLine("Give the second string:");
       string voice2 = Console.ReadLine();
       if(voice1 == voice2)
       {
        Console.WriteLine("Echo!");
       }
       else
       {
        Console.WriteLine("Nope!");
       }
            *********************************************************************************/
            /***********************************************Exercise032**********************
         Console.WriteLine("Speak, friend, and enter!");
       string voice = Console.ReadLine();
       if(voice == "Mellon")
       {
        Console.WriteLine("Welcome, friend");
       }
       else
       {
        Console.WriteLine("They've got a cave troll!");
       }     
            *********************************************************************************/
            /***********************************************Exercise031**********************
       Console.WriteLine("Give a number:");
       int number;
       number = Convert.ToInt32(Console.ReadLine());
       if(number % 2 == 0)
       {
        Console.WriteLine("It is even.");
       }
       else
       {
        Console.WriteLine("It is odd.");
       }       
            *********************************************************************************/
            /***********************************************Exercise030**********************
              Console.WriteLine("Give your percent [0 - 100]:");
       int number1;
       number1 = Convert.ToInt32(Console.ReadLine());
       if (number1 < 0)
       {
        Console.WriteLine("Impossible");
       }
       else if(number1 <= 49)
       {
        Console.WriteLine("Fail");
       }
       else if(number1 <= 59)
       {
        Console.WriteLine("Grade: 1");
       }
       else if(number1 <= 69)
       {
        Console.WriteLine("Grade: 2");
       }
       else if(number1 <= 79)
       {
        Console.WriteLine("Grade: 3");
       }
       else if(number1 <= 89)
       {
        Console.WriteLine("Grade: 4");
       }
       else if(number1 <= 100)
       {
        Console.WriteLine("Grade: 5");
       }
       else
       {
        Console.WriteLine("Outstanding!");
       }
            *********************************************************************************/
            /***********************************************Exercise029**********************
         Console.WriteLine("Give the first number!");
       int number1;
       number1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Give the second number!");
       int number2;
       number2 = Convert.ToInt32(Console.ReadLine());
       if (number1 > number2)
       {
        Console.WriteLine($"The larger number is {number1}!");
       }
       else if(number2 > number1)
       {
        Console.WriteLine($"The larger number is {number2}!");
       }
       else
       {
        Console.WriteLine("They are equal!");
       }      
            *********************************************************************************/
            /***********************************************Exercise028**********************
            Console.WriteLine("How old are you?");
    int number;
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 18)
    {
    Console.WriteLine("You're under age!");
    
    }
    else
    {
    Console.WriteLine("You're an adult!");
    }    
            *********************************************************************************/
            /***********************************************Exercise027**********************
            Console.WriteLine("Give a number:");
int speed;
speed = Convert.ToInt32(Console.ReadLine());
if (speed > 0)
{
    Console.WriteLine("It is positive");
    
}
else
{
    Console.WriteLine("It is not positive");
}  
            *********************************************************************************/
            /***********************************************Exercise026**********************
              Console.WriteLine("Give your year of birth:");
      int speed;
      speed = Convert.ToInt32(Console.ReadLine());
      if (speed < 1900) 
        {
        Console.WriteLine("You're old");
        }
            *********************************************************************************/
            /***********************************************Exercise025**********************
              Console.WriteLine("Give a number:");
      int speed;
      speed = Convert.ToInt32(Console.ReadLine());
      if (speed == 1984) 
        {
        Console.WriteLine("Orwell");
        }
            *********************************************************************************/
            /***********************************************Exercise024**********************
              Console.WriteLine("Your speed:");
      int speed;
      speed = Convert.ToInt32(Console.ReadLine());
      if (speed > 120) 
        {
        Console.WriteLine("Speeding!");
            *********************************************************************************/
            /***********************************************Exercise023**********************
              Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      int result1 = number1 + number2;
      int result2 = number1 - number2;
      int result3 = number1 * number2;
      double result4 = (double)number1 / number2;


      Console.WriteLine($"{number1} + {number2} = {result1}");
      Console.WriteLine($"{number1} - {number2} = {result2}");
      Console.WriteLine($"{number1} * {number2} = {result3}");
      Console.WriteLine($"{number1} / {number2} = {result4}");
      
            *********************************************************************************/
            /***********************************************Exercise022**********************
              Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the third number!");
      int number3;
      number3 = Convert.ToInt32(Console.ReadLine());
      double result = ((number1 + number2 + number3) / 3.0);

      Console.WriteLine("The average is " + result);

            *********************************************************************************/
            /***********************************************Exercise021**********************
                Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the third number!");
      int number3;
      number3 = Convert.ToInt32(Console.ReadLine());
      double result = ((number1 + number2 + number3) / 3.0);

      Console.WriteLine("The average is " + result);
            *********************************************************************************/

            /***********************************************Exercise020**********************
              Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      int result = number1 * number2;
      Console.WriteLine($"{number1} * {number2} = {result}");
            *********************************************************************************/
            /***********************************************Exercise19**********************
              Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      int result = number1 + number2;
      Console.WriteLine($"{number1} + {number2} = {result}");
    }
            *********************************************************************************/
            /***********************************************Exercise018**********************
              Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the third number!");
      int number3;
      number3 = Convert.ToInt32(Console.ReadLine());
      int result = number1 + number2 + number3;
      Console.WriteLine("The sum is "+ result);
            *********************************************************************************/
            /***********************************************Exercise017**********************
Console.WriteLine("Give the first number!");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      int result = number1 + number2;
      Console.WriteLine("The sum is "+ result);
            *********************************************************************************/

            /***********************************************Exercise016**********************
              public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(number1 * 24 * 60 * 60);
            *********************************************************************************/

            /***********************************************Exercise015**********************
              Console.WriteLine("Give a string:");
      string statement = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give a double:");
      double number2;
      number2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Give a boolean:");
      bool number;
      number = Convert.ToBoolean(Console.ReadLine());
      Console.WriteLine("Your string: "+statement);
      Console.WriteLine("Your integer: "+number1);
      Console.WriteLine("Your double: "+number2);
      Console.WriteLine("Your boolean: "+number);
            *********************************************************************************/
            /***********************************************Exercise014**********************
              Console.WriteLine("Give me the truth!");
      bool number;
      number = Convert.ToBoolean(Console.ReadLine());
      Console.WriteLine( number);
            *********************************************************************************/
            /***********************************************Exercise013**********************
              Console.WriteLine("Give a number!");
      double number;
      number = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("You gave " + number);
            *********************************************************************************/
            /***********************************************Exercise012**********************
              Console.WriteLine("Give a number!");
      int number;
      number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("You gave "+number);
            *********************************************************************************/
            /***********************************************Exercise011**********************
              int dayCount = 200;
      double hoursToLunch = 3.5;
      string statement = "It sure is!";
      
      // DO NOT TOUCH THESE!
      Console.WriteLine("Days to summer:");
      Console.WriteLine(dayCount);
      Console.WriteLine("Hours to lunch:");
      Console.WriteLine(hoursToLunch);
      Console.WriteLine("Coding is fun:");
      Console.WriteLine(statement);
            *********************************************************************************/
            /***********************************************Exercise010**********************
              string input = Console.ReadLine();

      string input2 = Console.ReadLine();
      Console.WriteLine("I will tell a story, but I need some information.\n"
      +"Give a name for main character:\n"
      +"Give the character a profession:\n"
      +"Here is the story:\n"+ "Once upon a time there was a "
      + input2 +" called "+ input +"\n"
      + "On her way to work, "+ input+" often pondered what being "+ input2 +" meant to them.\n"
      + "When you work as a "+ input2 +" you meet interesting people.\n"+ input
      +" enjoys their work as "+ input2 +", The end.");
            *********************************************************************************/
            /***********************************************Exercise09**********************
           string input = Console.ReadLine();
     Console.WriteLine("Hello, how are you?\n"+
     "That's interesting, tell me more" );
     string input2 = Console.ReadLine();
     Console.WriteLine( "Thank you for sharing!");   
            *********************************************************************************/
            /***********************************************Exercise08**********************
      Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello\n "+input+ "!");        
            *********************************************************************************/
            /***********************************************Exercise07**********************
              Console.WriteLine("Give input!");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine(input);
            Console.WriteLine(input);
            *********************************************************************************/
            /***********************************************Exercise06**********************
              Console.Write("Give input!\n");
      string input = Console.ReadLine();
      Console.WriteLine(input);
            *********************************************************************************/
            /***********************************************Exercise05**********************
              
            *********************************************************************************/
            /***********************************************Exercise04**********************
              string message = "Passport and a toothbrush!"; 
            Console.WriteLine(message);
            *********************************************************************************/
            /***********************************************Exercise03**********************
               Console.WriteLine
      ("Once upon a time\n"
      +"I was falling in love\n"
      +"Now I'm only falling apart");
            *********************************************************************************/
            /***********************************************Exercise02**********************
              Console.WriteLine("Once upon a time");
      Console.WriteLine("I was falling in love");
      Console.WriteLine("Now I'm only falling apart");
            *********************************************************************************/
            /***********************************************Exercise01**********************
              Console.WriteLine("Hello World!");
            *********************************************************************************/

        }
    }
}
