using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Calculator");

            //Prompt user for first value, assign variable name, then convert from string to number, allowing for decimal places. repeated for 2nd value.

            Console.Write("Enter value for X: ");
            string x = Console.ReadLine();
            decimal xNum = decimal.Parse(x);

            Console.Write("Enter value for Y: ");
            string y = Console.ReadLine();
            decimal yNum = decimal.Parse(y);

            //prompt user for action that should be taken with the two numbers they entered and assign variable name to it.

            Console.Write("Would you like to add, subtract, multiply, or divide? Please choose one: ");
            string maths = Console.ReadLine();

            //assign name and type to answer of calculation, used decimal to maintain consistency between two user-entered numbers and solution
            //declare outside of if/else if statement code so i can use it to print to console at the end of program
            //answer variable needed to be declared before it is first used in the first if statement
            decimal solution = 0;
            
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
            Console.WriteLine($"Answer: {solution}");
            Console.ReadLine();




        }
    }
}
