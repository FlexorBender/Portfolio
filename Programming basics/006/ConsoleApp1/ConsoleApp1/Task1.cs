using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    class MassSort
    {
        private int n = 0;

        public MassSort(int n)
        {
            if (n > 0)
            {
                m = new int[n];
                this.n = n;
            }
            else
            {
                Console.WriteLine("Длина массива может быть только положительным числом");
            }

        }
        private int[] m;
        public int[] M
        {
            get { return m; }
            set { m = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public void entry()
        {
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < this.N; i++)
            {
                Console.SetCursorPosition(i * 4, 13);
                M[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void finding()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(M[i] + "  ");
            }
        }

        public void sortPuz()
        {
            for (int i = N - 1; i >= 0 - 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (M[j] > M[j + 1])
                    {
                        int c = M[j];
                        M[j] = M[j + 1];
                        M[j + 1] = c;
                    }
                }
            }
        }

        public void sortShell()
        {
            int[] h = new int[5];
            h[0] = 9; h[1] = 5; h[2] = 3; h[3] = 2; h[4] = 1;
            for (int j = 0; j < 5; j++)
            {
                int k = h[j];
                for (int i = 0; i < n - k; i++)
                {
                    if (M[i] > M[i + k])
                    {
                        int c = M[i];
                        M[i] = M[i + k];
                        M[i + k] = c;
                    }
                }
            }
        }
    }
}