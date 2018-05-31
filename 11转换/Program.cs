using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11转换
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ConvClass1
    {
        public int Val;
        //隐式
        public static implicit operator ConvClass2(ConvClass1 op1)
        {
            ConvClass2 returnVal = new ConvClass2();
            returnVal.Val = op1.Val;
            return returnVal; 
        }
    }

    public class ConvClass2
    {
        public double Val;

        //显示
        public static explicit operator ConvClass1(ConvClass2 op1)
        {
            ConvClass1 returnVal = new ConvClass1();
            checked
            {
                returnVal.Val = (int)op1.Val;
            }
            return returnVal;
        }
    }
}
