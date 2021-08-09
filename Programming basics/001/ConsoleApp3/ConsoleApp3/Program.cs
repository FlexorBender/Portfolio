using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LW1_Option2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определения попадания в мишень");
            Console.WriteLine("Введите значение X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (y >= Math.Pow((x-2), 2) -3)
            {
                if (y <= x && y >= 0)
                {
                    Console.WriteLine("Вы попали в мишень!");
                }
                else
                {
                    if (-y >= x)
                    {
                        Console.WriteLine("Вы попали в мишень!");
                    }
                    else
                    {
                        Console.WriteLine("Промах!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Промах!");
            }
            Console.ReadKey();
        }
    }
}
