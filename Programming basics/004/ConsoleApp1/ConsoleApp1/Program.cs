using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class Counter
    {
        public int max;
        public int min;
        public int now;

        public Counter(int min, int max, int now)
        {
            this.min = min;
            this.max = max;
            this.now = now;
        }

        public int Inc()
        {
            now = now + 1;
            if (now > max)
                now = min;
            return now;
        }

        public int Low()
        {
            now = now - 1;
            if (now < min)
                now = max;
            return now;
        }

        public int Total()
        {
            return now;
        }
          class Equ
        {
            public double a;
            public double b;
            public double c;
            public void res(double a, double b, double c)
            {
                if ((b * b - 4 * a * c) >= 0)
                {
                    double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    Console.WriteLine("Первый корень= " + x1);
                    Console.WriteLine("Второй корень= " + x2);
                }
                else { Console.WriteLine("Корни отсутствуют"); }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                bool k2 = false;
                while (k2 == false)
                {
                    Counter x;
                    string menu;
                    int max, min, now;
                    Console.WriteLine("Меню программы");
                    Console.WriteLine("1)Десятичный счетчик.");
                    Console.WriteLine("2)Многочлен.");
                    Console.WriteLine("Введите номер задания:");
                    int menu1 = int.Parse(Console.ReadLine());
                    switch (menu1)
                    {
                        case 1:

                            Console.WriteLine("\nВведите  минимальное значение:");
                            while (!int.TryParse(Console.ReadLine(), out min)) Console.WriteLine("Неверный формат - попробуйте снова");
                            Console.WriteLine("Введите максимальное значение:");
                            while (!int.TryParse(Console.ReadLine(), out max)) Console.WriteLine("Неверный формат - попробуйте снова");
                            Console.WriteLine("Введите текущее значение:");
                            while (!int.TryParse(Console.ReadLine(), out now)) Console.WriteLine("Неверный формат - попробуйте снова");

                            x = new Counter(min, max, now);

                            bool key = true;
                            while (key == true)
                            {
                                Console.WriteLine("\n\n");
                                Console.WriteLine(" Введите действие");
                                Console.WriteLine("1. Увеличение");
                                Console.WriteLine("2. Уменьшение");
                                Console.WriteLine("3. Текущее значение и выход из программы");

                                menu = Console.ReadLine();
                                switch (menu)
                                {
                                    case "1":
                                        Console.WriteLine($"Значение переменной: {x.Inc()}");
                                        break;

                                    case "2":
                                        Console.WriteLine($"Значение переменной: {x.Low()}");
                                        break;

                                    case "3":
                                        Console.WriteLine($"Итоговое значение переменной: {x.Total()}");
                                        Console.WriteLine("\n");
                                        key = false;
                                        break;

                                    default:
                                        Console.WriteLine("Такого пункта нет. Повторите ввод");
                                        Console.WriteLine($"Значение переменной: {x.Total()}");
                                        break;
                                }
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            {
                                Console.WriteLine("Корни квадратного уравнения (Многочлен)");
                                Equ m = new Equ();
                                Console.WriteLine("Введите a");
                                m.a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите b");
                                m.b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите c");
                                m.c = Convert.ToInt32(Console.ReadLine());
                                m.res(m.a, m.b, m.c);
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                k2 = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Такого номера нет");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}



