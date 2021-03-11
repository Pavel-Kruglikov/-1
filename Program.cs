using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String enterString;
            Console.WriteLine("Enter string");
            enterString = Console.ReadLine();
            string[] words = enterString.Split(' ');

            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsPunctuation(words[i], words[i].Length - 1) == true)
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
