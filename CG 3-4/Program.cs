using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Calculator");

            //Prompt user for first value then convert from string to number, allowing for decimal places. repeated for 2nd value.

            Console.Write("Enter value for X: ");
            string x = Console.ReadLine();
            double xNum = double.Parse(x);

            Console.Write("Enter value for Y: ");
            string y = Console.ReadLine();
            double yNum = double.Parse(y);

            //prompt user for action that should be taken with the two numbers they entered.

            Console.Write("Would you like to add, subtract, multiply, or divide? Please choose one: ");
            string maths = Console.ReadLine();
        
            //assign value for answer to calculation, allowing for decimal places
            double solution = 0;
            
            //if and else if statements that calculate user-entered numbers based on the action the user instructed the program to take

            if (maths == "add")
                solution = xNum + yNum;

            else if (maths == "subtract")
                solution = xNum - yNum;

            else if (maths == "multiply")
                solution = xNum * yNum;

            else if (maths == "divide")
                solution = xNum / yNum;

            //else statement included to give error message if user does not enter one of the four actions given.

            else
                Console.WriteLine("Invalid Entry");

            
            //print the answer to the console
            Console.WriteLine("Answer: " + solution);
            Console.ReadLine();




        }
    }
}
