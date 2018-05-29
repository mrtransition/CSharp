using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 循环输出1~10
            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}",i);
            //}
            //Console.ReadKey();
            #endregion

            #region 打印图形
            double realCoord, imagCoord;
            double realTemp, imageTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = 1.2; imagCoord >= -1.2;imagCoord -=0.05)
            {
                for (realCoord =-0.6;realCoord <= 1.77;realCoord +=0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imageTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imageTemp * imageTemp) - realCoord;
                        imageTemp = (2 * realTemp * imageTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imageTemp * imageTemp);
                        iterations += 1; 
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break; 
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
