using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    class StupMass
    {
        public int[][] stmass;
        public int n;
        public int[] m;
        public StupMass(int n)
        {
            stmass = new int[n][];
            this.n = n;
            m = new int[n];
        }
        public void create()
        {
            Console.WriteLine("Введите количество элементов в ступенях");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Элементов в " + (i + 1) + " ступени = ");
                int d = int.Parse(Console.ReadLine());
                stmass[i] = new int[d];
                m[i] = d;
            }
        }
        public void input()
        {
            Console.SetCursorPosition(0, n + 10);
            Console.WriteLine("Введите значения ступенчатой матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m[i]; j++)
                {
                    Console.SetCursorPosition(j * 5, i + n + 15);
                    stmass[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void output()
        {
            Console.SetCursorPosition(0, n + 20);
            Console.WriteLine("Отсортированная по возрастанию ступенчатая матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m[i]; j++)
                {
                    Console.SetCursorPosition(j * 5, i + n * 3 + 19);
                    Console.WriteLine(stmass[i][j]);
                }
            }
        }
        public void sort()
        {
            int b = 0;

            for (int k = 0; k < m.Length; k++)
            {
                b = b + m[k];
            }
            int[] s = new int[b];
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < stmass[i].Length; j++)
                {
                    s[r] = stmass[i][j];
                    r++;
                }
            }

            for (int d = 0; d < s.Length; d++)
                for (int u = 0; u <= s.Length - 2; u++)
                {
                    if (s[u] > s[u + 1])
                    {
                        int v = s[u];
                        s[u] = s[u + 1];
                        s[u + 1] = v;
                    }
                }

            r = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < stmass[i].Length; j++)
                {
                    stmass[i][j] = s[r];
                    r++;
                }
            }
        }
    }
}
