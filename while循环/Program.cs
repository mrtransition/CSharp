﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 循环输出1~10
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("{0}",i++); 
            //}
            //Console.ReadKey();
            #endregion

            #region 银行利息计算
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)？");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine())/100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }

            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
                             totalYears,totalYears==1?"":"s",balance);
            if (totalYears == 0)
                Console.WriteLine(
                    "To be honest , you really didn't neet to use this calculator.");
            Console.ReadKey();
            #endregion

        }

    }
}
