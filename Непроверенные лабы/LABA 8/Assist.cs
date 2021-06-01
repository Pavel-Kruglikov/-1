using System;
using System.ComponentModel;

namespace _3cSharp
{
    static class Assist
    {
        static public void NumberCheck(string str, out int number)
        {
            try
            {
                if (!int.TryParse(str, out number))
                    throw new ArgumentException();
                else return;
            }

            catch (ArgumentException)
            {
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число ");
                }
            }
        }

        static public bool DefineBool(string word)
        
        {
            word.ToLower();
            while (true)
            {
                try
                {
                    switch (word)
                    {
                        case "1":
                        case "da":
                        case "да":
                        case "yes":
                        case "yeah":
                        case "true":
                        case "yup": return true;
                        case "0":
                        case "net":
                        case "нет":
                        case "no":
                        case "false":
                        case "nope": return false;
                        default: throw new ArgumentException();
                    }
                }
                catch(ArgumentException)
                {
                    bool result;
                   
                    while (!bool.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Ошибка ввода! Введите true / false ");
                    }

                    return result;
                }


            }
        }
    }
}
