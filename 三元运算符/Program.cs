using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string resultString;
            Console.Write("请输入myInteger值：");
            myInteger = Convert.ToInt32(Console.ReadLine());
            resultString = (myInteger > 10) ? "Less than 10" : "Greater than or equal to 10 ";
            Console.WriteLine("myInteger同10比较：{0}",resultString);
            Console.ReadKey();
        }
    }
}
