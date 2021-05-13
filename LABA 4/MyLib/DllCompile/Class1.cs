using System;

namespace DllCompile
{
    public static class Class1
    {
        public static double Plus(double fir,double sec)
        {
            return fir + sec;
        }
        public static double Minus(double fir, double sec)
        {
            return fir - sec;
        }
        public static double Multi(double fir, double sec)
        {
            return fir * sec;
        }
        public static double Divide(double fir, double sec)
        {
            if (sec!=0)
            {
                return fir / sec;
            }
            else
            {
                Console.WriteLine("ошибка, знаменатель не может быть равен нулю\n код возвращаемый от операции с ошибкой равен 0 имеет и сообщение,например как это ");
                return 0;
            }
            
        }
        public static double Ost(double fir,double sec)
        {
            
            if (sec != 0)
            {
                return fir % sec;
            }
            else
            {
                Console.WriteLine("ошибка, знаменатель не может быть равен нулю\n код возвращаемый от операции с ошибкой равен 0 имеет и сообщение,например как это ");
                return 0;
            }
        }
    }
}
