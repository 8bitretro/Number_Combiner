using System;

namespace Number_Combiner
{
    //main class
    class Program
    {
        //starting point
        static void Main(string[] args)
        {
            //app info
            string appname = "Number Combination Tool";
            string creator = "Chris";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} by {1}", appname, creator);
            Console.ResetColor();

            //continue code, should now be white

            Console.WriteLine("Please enter your first number");
            decimal firstNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            decimal secondNum = Convert.ToDecimal(Console.ReadLine());
            decimal sum = firstNum + secondNum;
            Console.WriteLine();
            Console.WriteLine("The sum of these numbers is: " + sum);


            Console.ReadLine();

        }
    }
}
