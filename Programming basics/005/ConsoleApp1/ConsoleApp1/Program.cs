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
            int a, b;
            Drob A = new Drob();
            Console.WriteLine("Введите числитель первой дроби:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Дробь не определена, значение по умолчанию");
            }
            else
            {
                A.Znam = b;
            }
            A.Chisl = a;
            A.Znam = b;
            A.Print();
            Drob B = new Drob();
            Console.WriteLine("Введите числитель второй дроби:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби:");
            b = Convert.ToInt32(Console.ReadLine());
            B.Chisl = a;
            B.Znam = b;
            B.Print();

            Drob S = new Drob();
            bool key = false;
            while (key == false)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Сложение статическим методом оператора");
                Console.WriteLine("2 - Вычитание статическим методом оператора");
                Console.WriteLine("3 - Умножение статическим методом оператора");
                Console.WriteLine("4 - Деление статическим методом оператора");
                Console.WriteLine("5 - Сложение перегруженным методом оператора");
                Console.WriteLine("6 - Вычитание перегруженным методом оператора");
                Console.WriteLine("7 - Умножение перегруженным методом оператора");
                Console.WriteLine("8 - Деление перегруженным методом оператора");
                Console.WriteLine("9 - Сложение дробей");
                Console.WriteLine("10- Вычитание дробей");
                Console.WriteLine("11 - Умножение дробей");
                Console.WriteLine("12 - Деление дробей");
                Console.WriteLine("13 - Выход из программы\n");
                string menu1 = Console.ReadLine();
                S.Znam = 1;
                S.Chisl = 0;
                switch (menu1)
                {
                    case "1":
                        S = Stat.Summa(A, B);
                        Drob.Cut(S);
                        S.Print();
                        break;
                    case "2":

                        S = Stat.Sub(A, B);
                        Drob.Cut(S);
                        S.Print();

                        break;
                    case "3":

                        S = Stat.MultSt(A, B);
                        Drob.Cut(S);
                        S.Print();
                        break;
                    case "4":

                        S = Stat.DivSt(A, B);
                        Drob.Cut(S);
                        S.Print();
                        break;
                    case "5":

                        S = A + B;
                        Drob.Cut(S);
                        S.Print();

                        break;
                    case "6":

                        S = A - B;
                        Drob.Cut(S);
                        S.Print();

                        break;
                    case "7":

                        S = A * B;
                        Drob.Cut(S);
                        S.Print();

                        break;
                    case "8":

                        S = A / B;
                        Drob.Cut(S);
                        S.Print();

                        break;

                    case "9":
                        S = A.Summa(B);
                        Drob.Cut(S);
                        S.Print();
                        break;

                    case "10":
                        S = A.Sub(B);
                        Drob.Cut(S);
                        S.Print();
                        break;

                    case "11":
                        S = A.Mult(B);
                        Drob.Cut(S);
                        S.Print();
                        break;

                    case "12":
                        S = A.Div(B);
                        Drob.Cut(S);
                        S.Print();
                        break;
                    case "13":
                        Console.WriteLine("Завершение сеанса\n");
                        key = true;
                        break;
                    default:
                        Console.WriteLine("Пункт отсутствует, введите ещё раз");
                        break;
                }
            }
        }
    }
}
