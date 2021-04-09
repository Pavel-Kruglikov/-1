using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a string with words separated by spaces. There are punctuation marks that are written immediately after the word. Add the punctuation mark after it before each word.
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            String enterString;
            Console.WriteLine("Enter string");
            enterString = Console.ReadLine();
            string[] words = enterString.Split(' ');//create an array of substrings
            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsPunctuation(words[i], words[i].Length - 1) == true)//check if the character is a punctuation mark
                {
                    Console.Write(words[i][words[i].Length - 1] + words[i]);
                }
                else
                {
                    Console.Write(words[i]);
                }
            }
            Console.Read();
        }
    }
}