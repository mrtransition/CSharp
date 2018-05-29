using System;

namespace _09定义类_EX01
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class MyBase3
    {

    }

    internal class MyClass10 : MyBase3
    {

    }

    public interface IMyBaseInterface
    {

    }

    internal interface IMyBaseInterface2
    {

    }

    internal interface IMyInterface3 : IMyBaseInterface, IMyBaseInterface2
    {

    }

    internal sealed class MyComplexClass : MyClass10, IMyInterface3
    {

    }


    class Ch09Ex01
    {
        static void main(string[] args)
        {
            MyComplexClass myobj = new MyComplexClass();
            Console.WriteLine(myobj.ToString());
            Console.ReadKey();
            Console.ReadKey();
        }
    }

}
