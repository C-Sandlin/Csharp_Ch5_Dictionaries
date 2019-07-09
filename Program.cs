using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> toysSold = new Dictionary<string, int>() {
                {"Hot Wheels", 344},
                {"Legos", 763},
                {"Gaming Consoles", 551},
                {"Board Games", 298}
            };

            toysSold.Add("Yoyo", 342);

            foreach (KeyValuePair<string, int> toy in toysSold)
            {
                Console.WriteLine($"The number of {toy.Key} is {toy.Value}");
            };

            Dictionary<string, int> newToys = new Dictionary<string, int>() {
                {"Red Ryder", 210},
                {"BB Gun", 763}
            };

            foreach (KeyValuePair<string, int> toy in newToys)
            {
                toysSold.Add(toy.Key, toy.Value);
            };

            Console.WriteLine("<<< After adding newToys >>>");
            foreach (KeyValuePair<string, int> toys in toysSold)
            {
                Console.WriteLine($"The number of {toys.Key} is {toys.Value}");
            };


        }
    }
}

