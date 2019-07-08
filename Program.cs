using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */

            var wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Yak", "Slang for 'to steal from another'");
            wordsAndDefinitions.Add("Bomb", "Also known colloquially as 'the best'");
            wordsAndDefinitions.Add("Dank", "Surfer talk for 'this is dope'");
            wordsAndDefinitions.Add("Dope", "Amazing; the state of being great");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Yak"]);
            Console.WriteLine(wordsAndDefinitions["Dank"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */


            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
