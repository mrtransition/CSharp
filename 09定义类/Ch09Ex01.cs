using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09定义类
{

    public abstract class MyBase3
    {

    }

    internal class MyClass10 : MyBase
    {

    }

    public interface IMyBaseInterface
    {

    }

    internal interface IMyBaseInterface2
    {

    }

    internal interface IMyInterface3 : IMyBaseInterface,IMyBaseInterface2
    {

    }

    internal sealed class MyComplexClass : MyClass10,IMyInterface
    {

    }


    class Ch09Ex01
    {
        static void main(string[] args)
        {
            MyComplexClass myobj = new MyComplexClass();
            Console.WriteLine(myobj.ToString());
            Console.ReadKey();
        }
    }
}
