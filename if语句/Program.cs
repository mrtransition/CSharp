using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单个数和10判断
            //string resultString;
            //int myInteger;
            //Console.Write("请输入myInteger值：");
            //myInteger = Convert.ToInt32(Console.ReadLine());
            //if (myInteger < 10)
            //    resultString = "小于10";
            //else
            //    resultString = "大于等于10";

            //Console.WriteLine("myInteger{0}。",resultString);
            //Console.ReadKey();
            #endregion

            #region 输入两个数比较大小
            string comparision; 
            Console.Write("请输入第一数：");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入第二个数：");
            double var2 = Convert.ToDouble(Console.ReadLine());

            if (var1 > var2)
            {
                comparision = "大于";
            }
            else
            {
                if (var1 == var2)
                    comparision = "等于";
                else
                    comparision = "小于";
            }

            Console.WriteLine("第一个数{0} {1} 第二个数{2}。",var1,comparision,var2);
            Console.ReadKey();
            #endregion
        }
    }
}
