using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            goto myLabel;

            myInteger += 10;

        myLabel:
            Console.WriteLine("myInteger = {0}", myInteger);
            Console.ReadKey();
        }
    }
}
