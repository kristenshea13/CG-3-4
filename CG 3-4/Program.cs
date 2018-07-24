using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Calculator");
            Console.Write("Enter value for X: ");
            string x = Console.ReadLine();
            int xInt = int.Parse(x);

            //assign string variable then convert to an integer


            Console.Write("Enter value for Y: ");
            string y = Console.ReadLine();
            int yInt = int.Parse(y);

            Console.Write("Would you like to add, subtract, multiply, or divide? Please choose one: ");
            string maths = Console.ReadLine();

            if (maths == "add")
            {
                int z = xInt + yInt;

            }

            else if (maths == "subtract")
            {


            }

            else if (maths == "multiply")
            {


            }


            else if (maths == "divide")
            {


            }






        }
    }
}
