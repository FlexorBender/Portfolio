using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LW1_Option2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Вычисление значения функции по графику");
            Console.WriteLine("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());
            if (x >= -7 && x <= 3)
            { if (x <= -6)
                {
                    y = 2;
                }
                else
                {
                    if (x <=-2)
                    {
                        y = 0.25 * x + 0.5;
                    }
                    else
                    {
                        if (x <= 0)
                        {
                            y = -Math.Sqrt(-(x * x) - 4 * x) + 2;
                        }
                        else
                        {
                            if (x <= 2)
                            {
                                y = Math.Sqrt(4 - x * x);
                            }
                            else
                            {
                                y = -1 * x + 2;
                            }
                        }
                    }
                }
                Console.WriteLine("Результат " + y);
            }
            else
            {
                Console.WriteLine("Ошибка. Функция не определена.");
            }
            Console.ReadKey();
        }
    }
}
