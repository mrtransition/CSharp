using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11封箱拆箱
{
    class Program
    {
        struct MyStruct
        {
            public int Val;
        }
        static void Main(string[] args)
        {
            MyStruct valType1 = new MyStruct();
            valType1.Val = 10;
            //封箱：包含值类型变量的一个副本的引用，而不包含源类型变量的引用
            object refType = valType1;

            //拆箱
            valType1.Val = 7;
            MyStruct varType2 = (MyStruct)refType;
            Console.WriteLine("varType2.Val={0}",varType2.Val);

            MyStruct2 valType3 = new MyStruct2();
            valType3.Val = 11;
            IMyInterface refType2 = valType3; 
            MyStruct2 valType4 = (MyStruct2)refType2;
            valType3.Val = 12;
            Console.WriteLine("valType4.Val={0}",valType4.Val);

            Console.ReadKey();

        }
    }

    interface IMyInterface
    {

    }
    struct MyStruct2 : IMyInterface
    {
        public int Val;
    }
}
