using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Серия попадания выстрелов");
            Console.WriteLine("Введите количество попыток попадания");
            Console.Write("n= ");
            int i = 0,
                n;
            n = Convert.ToInt32(Console.ReadLine());
            double x;
            double y;
            Console.WriteLine("Введите координаты точки (x,y)");
            while(i<n)
            {
                Console.Write("x= ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y= ");
                y = Convert.ToInt32(Console.ReadLine());
                if (y >= Math.Pow((x - 2), 2) - 3)
                {
                    if (y <= x && y >= 0)
                    {
                        Console.WriteLine("Точка попала в мишень!");
                    }
                    else
                    {
                        if (-y >= x)
                        {
                            Console.WriteLine("Точка попала в мишень!");
                        }
                        else
                        {
                            Console.WriteLine("Точка находиться за пределами мешени!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Точка находиться за пределами мешени!");
                }
                i += 1;
            }
              Console.ReadKey();
        }
    }
}
