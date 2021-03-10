using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//•	В заданной строке поменять порядок слов на обратный (слова разделены пробела-ми).
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String enterString;

            Console.WriteLine("Enter string");
            enterString = Console.ReadLine();

            string[] words = enterString.Split(' ');
            Array.Reverse(words);

            Console.WriteLine("Revered string");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
