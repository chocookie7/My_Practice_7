using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5._2
{
    internal class FindNumber
    {
        public int GetMax(int num1,int num2)
        {
            return num1 > num2?num1:num2;
        }
        public int GetMax(int num1,int num2,int num3)
        {
            int Max = num1;
            if (Max < num2) { Max = num2; }
            if (Max < num3) { Max = num3; }
            return Max;
        }
    }
}
