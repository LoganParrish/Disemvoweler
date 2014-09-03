using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("two drums and a cymbal fall off a cliff");
            Disemvoweler("Nickleback is my least favorite band. Their songwriting can be beat by a three year old.");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }
        static void Disemvoweler(string input)
        {
            input = input.ToLower();
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string chars = ".,'[]";
            string vowelString = string.Empty;
            string newInput = string.Empty;

            foreach (char b in input.ToLower())
            {
                if (vowels.Contains(b))
                {
                    vowelString = vowelString + b;
                }
                else if (consonants.Contains(b))
                {
                    newInput = newInput + b;
                }
                else if (chars.Contains(b))
                {
                    newInput = newInput + b;
                }

            }
            Console.WriteLine("\n\n\n\nThe vowels we extracted were : " + vowelString.ToUpper());
            Console.WriteLine("\n" + newInput.ToUpper());
        }
    }
}
