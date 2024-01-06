using System;
using System.Xml;

namespace class8._6
{
    public delegate double Mydelegate();
    class D
    {
        public event Mydelegate myEvent;
        private int score;
        public int Score
        {
            set { score = value; Output(); }
        }
        public int Output()
        {
            //return string.Format("{0}",score);
            Console.WriteLine(score);
        }
        public D(int s)
        {
            score = s;
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            D d= D(10);
            Mydelegate myEvent = new Mydelegate(D.Output());
            Console.WriteLine();
        }
    }
    

    
}
