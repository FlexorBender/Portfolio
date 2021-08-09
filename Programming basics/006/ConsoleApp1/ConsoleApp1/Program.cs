using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = true;
            string menu;
            while (key == true)
            {
                Console.WriteLine("Введите 1 Задание 1 «Сортировка»");
                Console.WriteLine("Введите 2 Задание 2 «Массивы»");
                Console.WriteLine("Введите 3 Задание 3 «Ступенчатые массивы» ");
                Console.WriteLine("Введите 4 Завершение сессии");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.Write("Введите длину массива: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            MassSort m = new MassSort(n);
                            m.entry();
                            Console.WriteLine("Сортировка пузырьком, нажмите 1");
                            Console.WriteLine("Сортировка Шелла, нажмите   2 ");

                            bool key1 = true;
                            string menu1;

                            while (key1 == true)
                            {
                                menu1 = Console.ReadLine();
                                switch (menu1)
                                {
                                    case "1":
                                        m.sortPuz();
                                        key1 = false;
                                        break;
                                    case "2":
                                        m.sortShell();
                                        key1 = false;
                                        break;

                                    default:
                                        {
                                            Console.WriteLine("Заданного номера нет в списке, выберите другой");
                                        }
                                        break;
                                }
                                m.finding();
                                Console.WriteLine();

                            }

                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Введите количество строк");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите количество столбцов");
                            int m = int.Parse(Console.ReadLine());
                            MyMass matr = new MyMass(n, m);
                            matr.random();
                            matr.finding();

                            bool key2 = true;
                            string menu2;

                            while (key2 == true)
                            {
                                Console.WriteLine("Для сортировки по возрастанию нажмите 1");
                                Console.WriteLine("Для сортировки по убыванию нажмите 2");
                                menu2 = Console.ReadLine();
                                switch (menu2)
                                {
                                    case "1":
                                        matr.sortIncrease();
                                        key2 = false;
                                        break;
                                    case "2":
                                        matr.sortDecrease();
                                        key2 = false;
                                        break;

                                    default:
                                        {
                                            Console.WriteLine("Заданного номера нет в списке, выберите другой");
                                        }
                                        break;
                                }
                                matr.finding();
                                Console.WriteLine();

                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Введите количество ступеней");
                            int n = int.Parse(Console.ReadLine());
                            StupMass stmas = new StupMass(n);
                            stmas.create();
                            stmas.input();
                            stmas.sort();
                            stmas.output();
                            Console.ReadLine();
                        }
                        break;
                    default:
                        {

                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Завершение сессии");
                            key = false;
                            break;
                        }
                }
            }
        }
    }
}
