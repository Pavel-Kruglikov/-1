using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace FourthLabNumberOne
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(35);
                for (int i = 0; i < 255; i++)
                {
                    if (GetAsyncKeyState(i)!=0)
                    {
                            Console.Write((char)i + " ");     
                    }
                    
                }
                
            }
        }
    }
}
