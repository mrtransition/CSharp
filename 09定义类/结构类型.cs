using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09定义类
{
    class 结构类型
    {
        static void Main(string[] args)
        {
            MyClass12 objectA = new MyClass12();
            MyClass12 objectB = objectA;

            objectA.val = 10;
            objectB.val = 20;

            myStruct structA = new myStruct();
            myStruct structB = structA;

            structA.val = 30;
            structB.val = 40;

            Console.WriteLine("objectA.val={0}",objectA.val);
            Console.WriteLine("objectB.val={0}", objectB.val);
            Console.WriteLine("structA.val={0}", structA.val);
            Console.WriteLine("structB.val={0}", structB.val);
            Console.ReadKey();
        }
    }

    class MyClass12
    {
        public int val;
    }

    struct myStruct
    {
        public int val;
    }
}
