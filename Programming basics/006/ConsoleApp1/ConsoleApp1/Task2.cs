using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyMass
{

    public MyMass()
    {

    }
    public int[,] matrix;
    public int n;
    public int m;
    public MyMass(int n, int m)
    {
        matrix = new int[n, m];
        this.n = n;
        this.m = m;
    }
    public void random()
    {
        Random matr = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

                matrix[i, j] = matr.Next(-100, 100);
            }
        }
    }
    public void finding()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "    ");
            }
            Console.WriteLine();
        }

    }
    public void sortIncrease()
    {
        int[] mas = new int[m];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                mas[j] += matrix[i, j];
            }
        }
        for (int i = 0; i < m - 1; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (mas[i] > mas[j])
                {
                    int c = mas[i];
                    mas[i] = mas[j];
                    mas[j] = c;
                    for (int r = 0; r < n; r++)
                    {
                        int c2 = matrix[r, j];
                        matrix[r, j] = matrix[r, i];
                        matrix[r, i] = c2;
                    }
                }
            }
        }
    }
    public void sortDecrease()
    {
        int[] mas = new int[m];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                mas[j] += matrix[i, j];
            }
        }
        for (int i = 0; i < m - 1; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (mas[i] < mas[j])
                {
                    int c = mas[i];
                    mas[i] = mas[j];
                    mas[j] = c;
                    for (int r = 0; r < n; r++)
                    {
                        int c2 = matrix[r, j];
                        matrix[r, j] = matrix[r, i];
                        matrix[r, i] = c2;
                    }
                }
            }
        }
    }

}
