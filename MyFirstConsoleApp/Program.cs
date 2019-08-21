using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVariable = 456;
            var myIntVariable = 123;

            switch (myIntVariable)
            {
                case 1:
                    Console.WriteLine("We'll never hit this code.");
                    break;
                case 2:
                    Console.WriteLine("We'll hit this code.");
                    break;
                default:
                    Console.WriteLine("We'll never hit this code.");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"We're on iteration {i}");
            }

            List<string> myStrings = new List<string>();
            myStrings.Add("blerg");
            myStrings.Add("blarg");
            myStrings.Insert(1, "blirg");
            myStrings.Remove("blirg");
            myStrings.RemoveAt(1);


            foreach (var myString in myStrings)
            {
                Console.WriteLine(myString);
            }

            Console.WriteLine(myVariable);5
        }
    }
}
