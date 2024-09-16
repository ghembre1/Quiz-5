using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz_5
{
    internal class Program
    {
        static void CheckDuplicate(string[] args) // method for checkduplicate
        { 

            for (int i = 0; i < args.Length; i++) // goes through every letter in the string
            {
                Console.WriteLine(args[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: "); // prompts user to enter a string
            string word = Console.ReadLine(); // takes users input

            CheckDuplicate(word);
            





            Console.WriteLine("Result: "); // prompts the user with the results
            
            Console.Read();
        }
    }
}
