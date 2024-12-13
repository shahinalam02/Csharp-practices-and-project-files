
using System;
//let's create a calculator program where we can add, subtract, multiply and divide two numbers and then ask the user if they want to perform another operation 
class Calculator
{
    public static void Main(string[] args)
    {
        while (true)
        {

            //ask the user for the first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //ask the user for the second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //ask the user for the operation they want to perform
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Enter your choice: ");
            int operation = Convert.ToInt32(Console.ReadLine());
            //perform the operation
            switch (operation)
            {
                case (1):
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case (2):
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case (3):
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case (4):
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {(double)num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    break;
            }

            //ask the user if they want to perform another operation
            Console.Write("You want to create another calculator? (y/n): ");
            char answer = (char)Console.Read();
            Console.WriteLine("");

            //if they want to perform another operation, go back to the beginning of the loop
            if (answer != 'y')
            {
                //if they don't want to perform another operation, exit the program
                Console.WriteLine("Goodbye!");
                break;

            }
        }
    }

}




