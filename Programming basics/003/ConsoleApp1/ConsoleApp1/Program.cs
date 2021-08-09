using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool k2 = false;
            while (k2 == false)
            {
                Console.WriteLine("Меню программы");
                Console.WriteLine("1)Ввод и обработка матриц.");
                Console.WriteLine("2)Перевод из двоичной системы счисления в десятичную.");
                Console.WriteLine("Введите номер задания:");
                int menu1 = int.Parse(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        Console.Write("Введите размер первой квадратной матрицы: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Введите размер второй квадратной матрицы: ");
                        int m = int.Parse(Console.ReadLine());
                        if (n > 10)
                        {
                            Console.Write("Слишком большой размер первой матрицы. Введите размер меньше 10");
                            n = int.Parse(Console.ReadLine());
                        }
                        if (m > 10)
                        {
                            Console.Write("Слишком большой размер второй матрицы. Введите размер меньше 10");
                            m = int.Parse(Console.ReadLine());
                        }
                        if (n == m)
                        {
                            int[,] mas1 = new int[n, n];
                            int[,] mas2 = new int[m, m];
                            int[,] mas3 = new int[10, 10];
                            Console.WriteLine("Введите 1 матрицу");
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Console.WriteLine("Введите mas1 [{0}, {1}]", i + 1, j + 1);
                                    mas1[i, j] = int.Parse(Console.ReadLine());

                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Введите 2 матрицу");
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Console.WriteLine("Введите mas2 [{0}, {1}]", i + 1, j + 1);
                                    mas2[i, j] = int.Parse(Console.ReadLine());

                                }
                            }
                            bool k1 = false;
                            while (k1 == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Введите 11 для сложения");
                                Console.WriteLine("Введите 22 для вычитания");
                                Console.WriteLine("Введите 33 для умножения");
                                Console.WriteLine("Введите 44 для выхода");
                                int q = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" Матрица А");
                                for (int o = 0; o < n; o++)
                                {
                                    for (int t = 0; t < n; t++)
                                    { Console.Write("{0,7:0}", mas1[o, t]); }
                                    Console.WriteLine();
                                }
                                Console.WriteLine(" Матрица B");
                                for (int y = 0; y < n; y++)
                                {
                                    for (int c = 0; c < n; c++)
                                    { Console.Write("{0,7:0}", mas2[y, c]); }
                                    Console.WriteLine();
                                }

                                switch (q)
                                {
                                    case 11:
                                        Console.WriteLine(" Сумма матриц");
                                        for (int z = 0; z < n; z++)
                                        {
                                            for (int v = 0; v < n; v++)
                                            { Console.Write("{0,7:0}", mas1[z, v] + mas2[z, v]); }
                                            Console.WriteLine();
                                        }
                                        break;
                                    case 22:
                                        Console.WriteLine(" Разность матриц");
                                        for (int f = 0; f < n; f++)
                                        {
                                            for (int d = 0; d < n; d++)
                                            { Console.Write("{0,7:0}", mas1[f, d] - mas2[f, d]); }
                                            Console.WriteLine();
                                        }
                                        break;
                                    case 33:
                                        Console.WriteLine(" Умножение матриц");
                                        int[,] r = new int[10, 10];
                                        for (int h = 0; h < n; h++)
                                        {
                                            for (int x = 0; x < n; x++)
                                            {
                                                r[h, x] = 0;
                                                for (int k = 0; k < n; k++)
                                                {
                                                    r[h, x] += mas1[h, k] * mas2[k, x];
                                                }
                                                Console.Write("{0,7:0}", r[h, x]);
                                            }
                                            Console.WriteLine();
                                        }
                                        break;
                                    case 44:
                                        k1 = true;
                                        break;
                                    default:
                                        Console.WriteLine("Введен некоректный номер операции");
                                        Console.ReadLine();
                                        break;
                                }
                            }
                        }

                        else { Console.WriteLine("Операции с матрицами таких размеров невозможны"); }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Перевод числа из десятичной ситемы в двоичную");
                        Console.WriteLine("Введите число в десятичной системе счисления:");
                        int xxx = Convert.ToInt32(Console.ReadLine());
                        int bbb = 0;
                        int mmm = xxx;
                        int iii = 1;
                        while (xxx > 0)
                        {
                            bbb = bbb + (xxx % 2) * iii;
                            iii *= 10;
                            xxx = xxx / 2;
                        }
                        Console.WriteLine("Число в десятичной системе счисления=" + mmm);
                        Console.WriteLine("Число в двоичной системе счисления=" + bbb);
                        string s = Convert.ToString(bbb);
                        char[] mas = new char[s.Length];
                        for (int j = 0; j < s.Length; j++)
                        {
                            mas[j] = s[j];
                        }

                        char l;

                        while (s.Length < 9)
                        {
                            s = '0' + s;
                        }

                        if (s.Length >= 9)
                        {
                            for (int j = s.Length - 1; j < s.Length - 3; j--)
                            {
                                l = mas[j + 6];
                                mas[j + 6] = mas[j];
                                mas[j] = l;
                            }
                            string u = String.Concat<char>(mas);
                            Console.WriteLine("Новое число со смененными 1 и 3 триадами=" + u);
                            double numb = 0;
                            string h;
                            double t = 0;
                            double o = 0;
                            int r = u.Length - 1;
                            while (r >= 0)
                            {
                                h = Convert.ToString(u[r]);
                                t = Convert.ToDouble(h);
                                numb = numb + t * (Math.Pow(2, o));
                                o++;
                                r--;
                            }

                            Console.WriteLine("Новое число в десятичной системе счисления=" + numb);
                        }
                        else
                        {
                            Console.WriteLine("Количества разрядов не достаточно для смены 1 и 3  триад");
                        }
                        Console.ReadKey();
                        break;
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