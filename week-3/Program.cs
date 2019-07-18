using System;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods are mostly the same
            // can still call other methods and such
            // method returns are the same
            // everything is affected by scope
            // methods need a return type - void for no return type

            double answer = average(1, 4, 23, 27);
            Console.WriteLine(answer);
        }
        static double average(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;

        }
    }
}
