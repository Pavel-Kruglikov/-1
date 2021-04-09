using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a string. Write down the numbers of characters included in it in the form of hexadecimal numbers separated by spaces.
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_string;
            Console.WriteLine("Enter your string");
            first_string = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(first_string);//encode a set of characters into a sequence of bytes
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                string hexOutput = String.Format("{0:X}", asciiBytes[i]);//convert object values to hexadecimal numbers
                while (hexOutput.Length < 4)
                {
                    hexOutput = 0 + hexOutput;
                }
                Console.Write(hexOutput);
                Console.Write(" ");       
            }
            Console.ReadKey();
        }
    }
}
