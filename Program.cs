using System;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Even or Odd Number? by 8bitretro");
        Start:
            Console.WriteLine();
            Console.WriteLine("Enter a number to determine if it is even or odd...");
            
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number {0} is even.", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", number);
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Type only numerals in the string from before...");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Try again? : y/n");
                string yesNo = Console.ReadLine();
                if (yesNo == "y")
                {
                    goto Start;
                }
                else if (yesNo == "n")
                {
                    System.Environment.Exit(0);
                }


            }
            
            
    }
    }
}
