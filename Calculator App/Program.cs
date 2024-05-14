using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("--------------");
                Console.WriteLine("Calculator App");
                Console.WriteLine("--------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation");
                Console.WriteLine("\t+: Addition");
                Console.WriteLine("\t-: subraction");
                Console.WriteLine("\t*: Multiplication");
                Console.WriteLine("\t/: Division");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result is : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result is : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result is : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result is : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Would you like to continue : Y = Yes, N = No");

                
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");

            Console.ReadKey();
        }

    }
}