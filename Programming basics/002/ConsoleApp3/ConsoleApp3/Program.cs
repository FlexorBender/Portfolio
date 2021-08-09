using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы ряда с заданной точностью");
            Console.WriteLine("Введите точность dx: ");
            double dx = Convert.ToDouble(Console.ReadLine());
            dx = Math.Abs(dx);
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > 1)
            {
                double x1, x2, i;
                x1 = (Math.PI / 2 - 1 / x);
                x2 = (Math.PI / 2 - 1 / x + 1 / (3 * x * x * x));
                i = 1;
                while (Math.Abs(x1 - x2) >= dx)
                {
                    i++;
                    x1 = x2;
                    x2 = x2 + Math.Pow(-1, i + 1) / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));

                }
                Console.WriteLine("Arctg(x)=" + x2);
                Console.WriteLine("Количество членов=" + i);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Некоректное значение");
            }
        }
    }
}
