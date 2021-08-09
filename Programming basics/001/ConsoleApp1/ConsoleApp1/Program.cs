using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW1_Option2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчёта по двум формулам");
            Console.WriteLine("Введите значение переменной");
            double a = Convert.ToDouble(Console.ReadLine());
            if ( a == 2 || a == 0 || a == -2 )
            {
                Console.WriteLine("Ошибка. Перепроверьте данные!"); 
            }   
            else
            {
                double b = (1 + a + a * a) / (2 * a + a * a) + 2 - (1 - a + a * a) / (2 * a - a * a);
                decimal z = Convert.ToDecimal(Math.Pow(b, -1) * (5 - 2 * Math.Pow(a, 2)));
                Console.WriteLine("Резутьтат по 1 формуле " + z);
                decimal z2 = Convert.ToDecimal((4 - a * a) / 2);
                Console.WriteLine("Результат по 2 формуле " + z2);
                Console.ReadKey();
            }
        }
    }
}
