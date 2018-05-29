using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 布尔运算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine("Integer less than 10?    {0}",isLessThan10);
            Console.WriteLine("Integer betweent 0 and 5?    {0}",isBetween0And5);
            Console.WriteLine("Exactly one of then above is true?   {0}",isLessThan10 ^ isBetween0And5);
            Console.ReadKey();

            int result, op1, op2;
            op1 = 100;
            op2 = 101;
            result = op1 & op2;
            Console.WriteLine("op1 & op2 结果是：{0}",result);
            Console.ReadKey();
        }
    }
}
