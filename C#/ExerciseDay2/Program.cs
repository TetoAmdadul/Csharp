using System;





class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hellow world");
        string studentName = "Fatimah";
        Console.WriteLine(studentName);
        int studentAge;
        Console.Write("Input student age :");
        studentAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Student age is " + studentAge);

        Console.Write("Is there any student : ");
        bool studentExists = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("It is " + studentExists);

        int math, drawing, finnish, bengali;
        Console.Write("Marks in math : ");
        math = Convert.ToInt32(Console.ReadLine());


        Console.Write("Marks in drawing : ");
        drawing = Convert.ToInt32(Console.ReadLine());

        Console.Write("Marks in finnish : ");
        finnish = Convert.ToInt32(Console.ReadLine());

        Console.Write("Marks in bengali : ");
        bengali = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(math + drawing + finnish + bengali);



    }
}