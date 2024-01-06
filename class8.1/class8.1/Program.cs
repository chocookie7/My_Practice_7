using System;

namespace class8._1
{
    public delegate double MyDelegate(double a);
    class D
    {
        private int d;
        public D(int s)
        {
            d = s;//创建构造方法，完成委托
        }
        public static double Sqrt(double a)
        {
            Math.Sqrt(a);//创建方法完成根除
        }
        public double Multi(double a)
        {
            return a * d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate m1, m2;//创建对象
            D d = new D(7);
            m1 = D.Sqrt;
            m2 = d.Multi;

            Console.WriteLine(m1(36));
            Console.WriteLine(m2(9));

        }
    }
}
