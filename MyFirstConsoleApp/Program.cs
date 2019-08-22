using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime purchaseDate = DateTime.Now;

            string lastName = "Smith";

            var firstName = "Bill";

            Console.WriteLine($"{firstName}{lastName} visted on {purchaseDate}");
            Console.ReadLine(); 
        }
    }
}
