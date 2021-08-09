using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Drob
    {
        private int znam;
        private int chisl;

        public Drob()
        {
            chisl = 0;
            znam = 1;
        }
        public Drob(int a, int b)
        {
            chisl = a;
            znam = b;

        }
        public int Chisl
        {
            get
            {
                return chisl;
            }
            set
            {
                chisl = value;
            }
        }
        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                if (value != 0)
                    znam = value;
            }
        }
        public Drob Summa(Drob c)
        {
            Drob c0 = new Drob();
            c0.Znam = Znam * c.Znam;
            Chisl *= c.Znam;
            c.Chisl *= Znam;
            c0.Chisl = Chisl + c.Chisl;
            return c0;
        }
        public Drob Sub(Drob c)
        {
            Drob c0 = new Drob();
            c0.Znam = Znam * c.Znam;
            Chisl *= c.Znam;
            c.Chisl *= Znam;
            c0.Chisl = Chisl - c.Chisl;
            return c0;
        }
        public Drob Mult(Drob c)
        {
            Drob c0 = new Drob();
            c0.Znam = Znam * c.Znam;
            c0.Chisl = Chisl * c.Chisl;
            if (c0.Znam == 0)
            {
                Console.WriteLine("Дробь не определена, значение по умолчанию");
                c0.Znam = 1;
            }
            return c0;
        }
        public Drob Div(Drob c) 
        {
            Drob c0 = new Drob();
            c0.Znam = Znam * c.Chisl;
            c0.Chisl = Chisl * c.Znam;
            if (c0.Znam == 0)
            {
                Console.WriteLine("Дробь не определена, значение по умолчанию");
                c0.Znam = 1;
            }
            return c0;
        }
        public int Nod(int a, int b)
        {
            int tem;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a % b > 0)
                {
                    tem = a;
                    a = b;
                    b = tem % b;
                }
                else break;
            }
            if (a != 0 && b != 0) return b;
            else return 0;
        }
        public static Drob Cut(Drob c0)
        {
            int Nod = c0.Nod(c0.Znam, c0.Chisl);
            if (Nod != 0)
            {
                c0.Chisl /= Nod;
                c0.Znam /= Nod;
            }
            return c0;
        }
        public static Drob operator +(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c1.Chisl *= c2.Chisl;
            c2.Chisl *= c1.Chisl;
            c0.Chisl = c1.Chisl + c2.Chisl;
            Drob.Cut(c0);
            return c0;
        }
        public static Drob operator -(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c1.Chisl *= c2.Chisl;
            c2.Chisl *= c1.Chisl;
            c0.Chisl = c1.Chisl - c2.Chisl;
            Drob.Cut(c0);
            return c0;
        }
        public static Drob operator *(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c0.Chisl = c1.Chisl * c2.Chisl;
            return c0;
        }
        public static Drob operator /(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam / c2.Znam;
            c0.Chisl = c1.Chisl / c2.Chisl;
            return c0;
        }
        public void Print()
        {
            Console.WriteLine(Chisl + "/" + Znam);
        }
    }
}