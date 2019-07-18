using System;
using System.Collections.Generic;

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

            // double answer = average(1, 4, 23, 27);
            // Console.WriteLine(answer);

            // Strings are mostly the same as well, just different names
            // C# has lots of basic features to do common tasks
            // substrings are also the same as are indexes


            // Arrays are mostly the same as well
            // can make arrays of specific size or do it dynamically
            // must have the type though

            // for each loops are the same
            // can be used on anything that is enumerable

            AddWords();


        }

        static bool RecurringWords(List<string> words, string word)
        {
            if (words.IndexOf(word) >= 0)
            {
                Console.WriteLine($"You already added {word}.");
                return false;
            }
            return true;

        }
        static void AddWords()
        {
            List<string> words = new List<string>();


            Console.WriteLine("Please enter a word: ");
            while (true)
            {
                string word = Console.ReadLine();
                if (String.IsNullOrEmpty(word))
                {
                    break;
                }
                else if (RecurringWords(words, word))
                {
                    words.Add(word);
                }
            }
            Console.WriteLine("You entered these words:");
            foreach (var word in words)
            {

                Console.WriteLine(word);
            }
        }
        static double average(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;

        }
    }
}
