using System;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd Number? by 8bitretro");
            Console.WriteLine();
            Console.WriteLine("Enter a number to determine if it is even or odd...");
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
    }
}
