using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// In the given line, reverse the order of words (words are separated by spaces).
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterString;
            Console.WriteLine("Enter string");
            enterString = Console.ReadLine();
            string[] words = enterString.Split(' ');//splitting into words
            Console.WriteLine("reversed:");
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
