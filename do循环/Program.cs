using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 把1~10输出到一列上
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("{0}", i++);
            //} while (i <= 10);
            //Console.ReadKey();
            #endregion

            #region 银行存款利息
            double balance, interesRate, targetBalance;
            Console.Write("你目前的余额是多少？");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("你们目前的年利率是多少(%)？");
            interesRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("你期望的金额是多少？");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interesRate;
                ++totalYears;
            } while (balance < targetBalance);

            Console.WriteLine("In {0} year{1} you'll have a balance of {2}",
                                totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();
            #endregion

        }
    }
}
