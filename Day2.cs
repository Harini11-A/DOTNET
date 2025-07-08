//WEEK ONE DAY 2

//EVEN OR ODD NUMBER 

/*
using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(number + " is odd");
                Console.ReadLine();
            }
        }
    }
}
*/

//FACTORIAL OF A NUMBER

/*
using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact =fact*i;
            }
                Console.WriteLine(fact);
                Console.ReadLine();
            }
        }
    }
*/


//PRINTING MULTIPLICATION TABLE
/*
using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + number*i);
              
            }
            Console.ReadLine();
        }
    }
}
*/

//DAY 2 TASK 
//MENU DRIVEN CALCULATOR
/*
using System;
class calculator
{
    static void Main(string[] args)
    {
         Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.Write("Enter the choice(1-4): ");
        int choice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Result : " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Result : " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Result : " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Result : " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Enter the valid choice.");
                break;
        }
        Console.ReadLine();
        }
}

*/