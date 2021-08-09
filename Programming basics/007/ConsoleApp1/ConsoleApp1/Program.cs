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
            Boolean flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Подсчитать в строке число букв");
                Console.WriteLine("2 - Подсчитать в строке среднюю длину слова");
                Console.WriteLine("3 - Заменить все вхождения выбранного слова");
                Console.WriteLine("4 - Подсчитать в строке количество вхождений заданной подстроки");
                Console.WriteLine("5 - Проверить, является ли строка палиндромом");
                Console.WriteLine("6 - Проверьть, является ли введенная строка датой ");
                Console.WriteLine("0 - Завершение сессии");

                int menu = Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        {
                            flag = false;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine();
                            Console.WriteLine("Количество букв в строке: " + PrString.SummLetters(s.ToCharArray()));
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine();
                            Console.WriteLine("Средня длина слова в строке: " + PrString.AverageWordLength(s.ToCharArray()));
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine().ToLower();
                            Console.WriteLine("Введите слово, которое хотите заменить");
                            String rep = Console.ReadLine();
                            Console.WriteLine("Введите новое слово");
                            String ins = Console.ReadLine();
                            s = PrString.ChangeString(s, rep, ins);
                            Console.WriteLine("Результат:");
                            Console.WriteLine(s);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine().ToLower();
                            Console.WriteLine("Введите подстроку, вхождения которой необходимо подсчитать");
                            String sub = Console.ReadLine();
                            Console.WriteLine("Количество вхождений подстроки в строку:" + PrString.CountSubstrings(s, sub));
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine().ToLower();
                            Console.WriteLine(PrString.Palindrome(s) ? "Палиндром" : "Не является палиндром");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите строку:");
                            String s = Console.ReadLine();
                            Console.WriteLine(PrString.Date(s) ? "Строка является датой" : "Строка НЕ является датой");
                            Console.ReadKey();
                            break;
                        }

                }
            }
        }

    }
}
