

using System;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");

            int number = Convert.ToInt32(Console.ReadLine());
            int total = number + 25;
            Console.WriteLine("Your number + 25 is:" + total);



            Console.WriteLine("Enter your age:");

            int age = Convert.ToInt32(Console.ReadLine());
            double number1 = age * 50;
            Console.WriteLine("Your number * 50 is:" + number1);


            Console.WriteLine("Enter your favorite number:");

            int favNum = Convert.ToInt32(Console.ReadLine());
            float number2 = favNum / 12.5f;
            Console.WriteLine("Your number / 12.5 is:" + number2);

            Console.WriteLine("Enter your birth year:");

            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 50) ;
            Console.WriteLine("True");


            Console.WriteLine("Enter your street number:");
            int street = Convert.ToInt32(Console.ReadLine());
            int remainder = street % 7;
            Console.WriteLine(remainder);




        }



    }


    }





