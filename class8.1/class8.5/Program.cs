using System;

namespace class8._5
{
    class D
    {
        private int d;
        public D(int s)
        {
            d = s;
        }
        public double Sqrt(double a)
        {
            Math.Sqrt(a);
        }
        public double Multi(double a)
        {
            return a * d;
        }

    }
    internal class Program
    {
        public delegate double Mydelegate(double a);

        static void Main(string[] args)
        {
            D dl=new D(7);
            Mydelegate m1, m2;
            m1 = D.Sqrt(dl);
            m2 = dl.Multi;
            Console.WriteLine("获奖了就好好休息一下");

        }
    }
   
}
