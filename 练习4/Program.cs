using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 判断两个数其中一个大于10的练习（使用^）
            //int var1, var2;
            //Console.Write("请输入var1的值：");
            //var1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入var2的值：");
            //var2 = Convert.ToInt32(Console.ReadLine());
            //bool compare;
            //if (var1 > 10 ^ var2 > 10)
            //{
            //    compare = true;
            //}
            //else
            //{
            //    compare = false;
            //}

            //Console.WriteLine("var1({0})、var2({1})其中一个是否大于10的判断结果是{2}",
            //    var1,var2,compare);
            //Console.ReadKey();
            #endregion

            #region 判断两个数其中一个大于10，但拒绝接受两个数字都大于10的情况，并要求重输
            int var1, var2;
            bool compare;
            bool compare2;
            do
            {
                Console.Write("请输入第一数的值：");
                var1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入第二个数的值：");
                var2 = Convert.ToInt32(Console.ReadLine());
                //判断两个数其中一个大于10
                if (var1 > 10 ^ var2 > 10)
                {
                    //当其中一个大于10时成立
                    compare = true;
                    compare2 = false;
                }
                else
                {
                    compare = false;
                    if (var1 > 10 && var2 > 10)
                    {
                        compare2 = true;
                        Console.WriteLine("输入有误，不能同时输入两个都大于10的数，请重新输入！");
                    }
                    else
                        compare2 = false;
                }
            } while (compare2);
            Console.WriteLine("var1({0})、var2({1})其中一个是否大于10的判断结果是{2}",
                var1, var2, compare);
            Console.ReadKey();
            #endregion
        }
    }
}
