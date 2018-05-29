using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 入门1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myVariableisGood;
            //int 99Flake;  //不符合规范
            //int _floor;
            //int time2GetJiggyWidit;
            //int worx.com; //不符合规范
            string temp;
            temp = "supercalifragilisticexpialidocious";
            int resultVar=0;
            int var1, var2, var3, var4, var5;
            var1 = 10;
            var2 = 20;
            var3 = 30;
            var4 = 6;
            var5 = 5;
            resultVar += var1 * var2 + var3 % var4 / var5;
            //10 * 20 + 30%6 / 5 + 0 = 200
            Console.WriteLine("resultVar={0}",resultVar);
            Console.ReadKey();

            Console.Write("请输入第一个数：");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数：");
            var2 = Convert.ToInt32( Console.ReadLine());
            Console.Write("请输入第三个数：");
            var3 = Convert.ToInt32( Console.ReadLine());
            Console.Write("请输入第四个数：");
            var4 = Convert.ToInt32(Console.ReadLine());
            resultVar = var1 * var2 * var3 * var4;
            Console.WriteLine("四个数的乘积是：{0}" ,resultVar);
            Console.ReadKey();
        }
    }
}
