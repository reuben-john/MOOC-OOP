using System;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print line to console
            // Console.WriteLine("Hello World!");
            // int months = 12;
            // String text = "includes text";
            // String name = "Reuben";
            // int wholeNumber = 123;
            // double decimalNumber = 3.141;
            // Boolean isTrue = true;
            // Console.WriteLine(months);
            // Console.WriteLine(text);
            // Console.WriteLine(wholeNumber);
            // Console.WriteLine(decimalNumber);
            // Console.WriteLine(isTrue);
            // Console.WriteLine($"Hello {name}"); // String interpolation ala JS

            // Types are immutable - results in error
            // String text = "hahahaha";
            // text = 42;

            // Exercise 4:

            // int chickens = 3;
            // double bacon = 5.5;
            // String tractor = "none";

            // Console.WriteLine("Chickens:");
            // Console.WriteLine(chickens);
            // Console.WriteLine("bacon (kg):");
            // Console.WriteLine(bacon);
            // Console.WriteLine("A tractor:");
            // Console.WriteLine($"There is {tractor}!");

            // chickens = 9000;
            // bacon = 0.1;
            // tractor = "Zetor";

            // Console.WriteLine("Chickens:");
            // Console.WriteLine(chickens);
            // Console.WriteLine("bacon (kg):");
            // Console.WriteLine(bacon);
            // Console.WriteLine("A tractor:");
            // Console.WriteLine($"There is {tractor}!");

            // math is the same
            // + - / * %

            // int a = 4 + 1 - 3 * 23 / 4 % 2;
            // Console.WriteLine(a);
            // a += 23;
            // Console.WriteLine(a);
            // Increment and decrement are ++a and --a

            // Division of int produces int
            // Must use double to get decimal
            // Remainer is modulus %

            // Can convert using type casting

            // Implicit conversion
            // Any smaller num type can fit inside a bigger num type
            // int num = 123;
            // long bigNum = num;

            // Explicit conversion
            // double x = 123.4;
            // int a;
            // a = (int)x;
            // Console.WriteLine(a);

            // // Seconds in a year
            // int second = 1;
            // int secondsInMinute = second * 60;
            // int secondsInHour = secondsInMinute * 60;
            // int secondsInDay = secondsInHour * 24;
            // int secondsInYear = secondsInDay * 365;

            // Console.WriteLine($"There are {secondsInYear} seconds in a year.");

            // Concontenating uses + still
            // It takes order of operations into play

            int a = 5;
            int b = 4;
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));

        }
    }
}
