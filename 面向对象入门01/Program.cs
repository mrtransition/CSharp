using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象入门01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person wangWu = new Person();
            wangWu.Name = "王五";
            wangWu.Age = 10;
            wangWu.Sex = "男";
            wangWu.PrintInfo();
            Console.ReadKey();
        }
    }
}
