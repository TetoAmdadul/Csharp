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




            /***********************************************o2Exercise021*********************



             *********************************************************************************/
            /***********************************************02Exercise020*********************



          *********************************************************************************/
            /***********************************************02Exercise019*********************



          *********************************************************************************/
            /***********************************************o2Exercise018*********************



          *********************************************************************************/
            /***********************************************02Exercise017*********************



          *********************************************************************************/
            /***********************************************02Exercise016*********************



          *********************************************************************************/
            /***********************************************o2Exercise015*********************



             *********************************************************************************/
            /***********************************************02Exercise014**********************



          *********************************************************************************/
            /***********************************************02Exercise013*********************



          *********************************************************************************/
            /***********************************************o2Exercise012*********************



           *********************************************************************************/
            /***********************************************02Exercise011**********************



          *********************************************************************************/
            /***********************************************02Exercise010**********************



          *********************************************************************************/
            /***********************************************o2Exercise09**********************



            *********************************************************************************/
            /***********************************************02Exercise08**********************
            namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
               int number = 0;
  int sum = 0;
  int totalNumbers = 0;
  float average = 0;
  int even = 0;   
  int odd = 0;
  Console.WriteLine("Give numbers:");


  while (true)
  {

      number = Convert.ToInt32(Console.ReadLine());
      if (number == -1)
      {
          break;
      }
      else

      {

          sum = sum + number;
          totalNumbers++;
         
          if  (number  % 2 == 0)
          {
              even++;

          }
          else
          {
              odd++;
          }
      }

  }

  average = (float)sum / totalNumbers;
  Console.WriteLine("Thx! Bye!");
  Console.WriteLine("Sum: " + sum);
  Console.WriteLine($"Numbers: {totalNumbers}");
  Console.WriteLine("Average: " + average);
  Console.WriteLine("Even: " + even);
  Console.WriteLine("Odd: " + odd);      
        }
    }
}


          *********************************************************************************/
            /***********************************************02Exercise07**********************
            namespace Exercise007
{
using System;
public class Program
{
public static void Main(string[] args)
{
   Console.WriteLine("Where to?");
   int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Where from?");
int number2 = Convert.ToInt32(Console.ReadLine());
for (int i = number2; i <= number1; i++)
{

  Console.WriteLine(i);
}
}
}
}


          *********************************************************************************/
            /***********************************************o2Exercise06**********************

            namespace Exercise006
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
  for (int i = number1; i <= 100; i++)
  {
      Console.WriteLine(i);
  }
    }
  }
}

          *********************************************************************************/
            /***********************************************02Exercise5**********************

             int number1 = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i<= number1; i++)
      {
        Console.WriteLine(i);
      }

          *********************************************************************************/
            /***********************************************02Exercise04**********************

             int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
 if (number1 > number2)
     {
     Console.WriteLine($"{number1} is greater than {number2}.");
     }
     else if (number1 <  number2)
     {
      Console.WriteLine($"{number1} is less than {number2}.");
     }
     else
 {
     Console.WriteLine($"{number1} is equal to {number2}.");
 }

          *********************************************************************************/
            /***********************************************o2Exercise03**********************

            namespace Exercise003
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number1 = Convert.ToInt32(Console.ReadLine());
 if (number1 < 0)
 {
     Console.WriteLine(number1 * -1);
 }
     else
 {
     Console.WriteLine(number1);
 }
    }
  }
}

          *********************************************************************************/
            /***********************************************02Exercise02**********************
            namespace Exercise002
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
       int number1 = Convert.ToInt32(Console.ReadLine());
       int number2 = Convert.ToInt32(Console.ReadLine());

       double squareRoot = Math.Sqrt(number1 + number2);
       Console.WriteLine(squareRoot);
    }
  }
}



          *********************************************************************************/
            /***********************************************02Exercise01**********************

            namespace Exercise001
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {

      int number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(number * number);
    }
  }
}


          *********************************************************************************/



            /***********************************************Exercise040**********************

            namespace Exercise040
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;
int sum = 0;int  totalNumber = 0;

while (true)
{
    Console.WriteLine("Give a number:");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        break;
    }

    {
        sum = sum + number;
        totalNumber++;
        continue;
    }

}
Console.WriteLine("Total sum of numbers: " + sum+"\n" + "Total amount of numbers: " + totalNumber);
    }
  }
}

             *********************************************************************************/


            /***********************************************Exercise039**********************

            namespace Exercise039
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;
       int sum = 0;

 while (true)
 {
     Console.WriteLine("Give a number:");
     number = Convert.ToInt32(Console.ReadLine());
     if (number == 0)
     {
         break;
     }

     {
         sum = sum + number;
         continue;
     }

 }
 Console.WriteLine("Total sum of numbers: "+sum);
    }
  }
}

            *********************************************************************************/

            /***********************************************Exercise038**********************
            int number = 0;
 int totalNumber = 0;

 while (true)
 {
     Console.WriteLine("Give a number:");
     number = Convert.ToInt32(Console.ReadLine());
     if (number == 0)
     {
         break;
     }
     else if(number > 0) {


         continue;

     }
     else
     {
         totalNumber++;
         continue;
     }

 }
 Console.WriteLine("Total amount of negative numbers: "+totalNumber);


            *********************************************************************************/


            /***********************************************Exercise037**********************

            namespace Exercise037
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number = 0;
int totalNumber = 0;

while (true)
{
    Console.WriteLine("Give a number:");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        break;
    }
    else
    {
        totalNumber++;
    }

}
Console.WriteLine("Total amount of numbers: "+totalNumber);
    }
  }
}

            *********************************************************************************/



            /***********************************************Exercise036**********************
            namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
       int number = 1;

while (true)
{
    Console.WriteLine("Give a number:");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        break;

    }
    else if (number < 0)
    {
        Console.WriteLine("That is negative");
    }
    else
    {
        Console.WriteLine(number * number);
        continue;
    }



}

    }
  }
}

           *********************************************************************************/
            /***********************************************Exercise035**********************
        namespace Exercise035
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
       int number = 1;

 while (true)
 {
     Console.WriteLine("Give a number:");
     number = Convert.ToInt32(Console.ReadLine());
     if (number == 42)
     {
         break;
     }
 }
    }
  }
}

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
