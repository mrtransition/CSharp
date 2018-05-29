using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09定义类
{
    class 类实例化顺序
    {
        public static void main(String[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass();
            /*
             * 执行顺序：
             * 执行System.object.object构造函数
             * 执行MyBaseClass.MyBaseClass()构造函数
             * 执行MyDerivedClass.MyDerivedClass()构造函数
             * */
            MyDerivedClass myObj2 = new MyDerivedClass(4);
            /*
            * 执行顺序：
            * 执行System.object.object构造函数
            * 执行MyBaseClass.MyBaseClass()构造函数
            * 执行MyDerivedClass.MyDerivedClass(int i)构造函数
            * */
            MyDerivedClass myObj3 = new MyDerivedClass(4,8);
            /*
            * 执行顺序：
            * 执行System.object.object构造函数
            * 执行MyBaseClass.MyBaseClass()构造函数
            * 执行MyDerivedClass.MyDerivedClass(int i,int j)构造函数
            * */
            MyDerivedClass2 myObj4 = new MyDerivedClass2(4, 8);
            /*
            * 执行顺序：
            * 执行System.object.object构造函数
            * 执行MyBaseClass.MyBaseClass(int i)构造函数
            * 执行MyDerivedClass2.MyDerivedClass(int i,int j)构造函数
            * */
            MyDerivedClass2 myObj5 = new MyDerivedClass2();
            /*
            * 执行顺序：
            * 执行System.object.object构造函数
            * 执行MyBaseClass.MyBaseClass(int i)构造函数
            * 执行MyDerivedClass2.MyDerivedClass(int i,int j)构造函数
            * 执行MyDerivedClass2.MyDerivedClass()构造函数
            * */
        }
    }

    public class MyBaseClass
    {
        public MyBaseClass()
        {

        }

        public MyBaseClass(int i)
        {

        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass()
        { }

        public MyDerivedClass(int i)
        { }

        public MyDerivedClass(int i, int j)
        { }
    }

    public class MyDerivedClass2 : MyBaseClass
    {
        public MyDerivedClass2() : this(5,6)
        { }

        public MyDerivedClass2(int i)
        { }

        public MyDerivedClass2(int i, int j) : base(i)  //制定所使用的基类构造函数
        { }


    }

}
