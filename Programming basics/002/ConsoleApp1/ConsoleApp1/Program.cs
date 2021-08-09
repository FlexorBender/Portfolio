using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица значений функции");
            Console.WriteLine("Введите минимальное значение функции: ");
            Console.WriteLine("xmin= ");
            double xmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение функции: ");
            Console.WriteLine("xmax= ");
            double xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг функции: ");
            Console.WriteLine("dx= ");
            double dx = Convert.ToDouble(Console.ReadLine());
            double y;
          
            for (double x = xmin; x<= xmax;x+= dx)
            {
                if (x >= -7 && x <= 11)
                {
                    if (x >= -7 && x <= -3)
                    {
                        y = 3;
                    }
                    else
                    {
                        if (x > -3 && x < 3)
                        {
                            y = Math.Sqrt(9 - x * x);
                        }
                        else
                        {
                            if (x >= 3 && x <= 6)
                            {
                                y = -2 * x + 9;
                            }
                            else
                            {
                                y = x - 9;
                            }

                        }
                    }
                    Console.WriteLine("{0,16:0.00}{1,16:0.00}", x,y) ;
                }
                else
                {
                    Console.WriteLine("{0,16:0.00}               y не определен",x);

                }

            }Console.ReadKey();
           
        }
    }
}
