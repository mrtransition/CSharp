using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环中断
{
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region break演示 当i=6时，中止循环
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i == 6) 
            //        break;
            //    Console.WriteLine("{0}",i++);
            //}
            //Console.ReadKey();
            #endregion

            #region continue演示：10以内显示奇数
            //int i = 1;
            //for (i = 1; i <= 10; i++)
            //{
            //    if ((i % 2) == 0)
            //        continue;
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            #endregion

            #region goto演示 当i=6时，跳转至其他位置
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    goto exitPoint;
                Console.WriteLine("{0}",i++);
            }
            Console.WriteLine("This code will never be reached.");
            exitPoint:
            Console.WriteLine("This code is run when the loop is exited using goto.");
            Console.ReadKey();
            #endregion
        }
    }
}
