using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Stat
    {

        static public Drob Summa(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c1.Chisl *= c2.Znam;
            c2.Chisl *= c1.Znam;
            c0.Chisl = c1.Chisl + c2.Chisl;
            return c0;
        }
        static public Drob Sub(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c1.Chisl *= c2.Znam;
            c2.Chisl *= c1.Znam;
            c0.Chisl = c1.Chisl - c2.Chisl;
            return c0;
        }
        static public Drob MultSt(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Znam;
            c0.Chisl = c1.Chisl * c2.Chisl;
            return c0;
        }
        static public Drob DivSt(Drob c1, Drob c2)
        {
            Drob c0 = new Drob();
            c0.Znam = c1.Znam * c2.Chisl;
            c0.Chisl = c1.Chisl * c2.Znam;
            return c0;
        }
    }
}

