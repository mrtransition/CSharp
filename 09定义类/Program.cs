using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09定义类
{
    /*
     * 前缀修饰
     1、缺省 internal 内部的：只有当前项目中的代码才可以访问
     2、public 公共的：可以由其他项目中的代码访问
     
     1、abstract 抽象的：不能实例化，只能继承
     2、sealed 密闭的：不能继承
     
     所有类的根都是System.Object   
         */
    class Program
    {

    }

    //抽象
    public abstract class MyClass
    {

    }

    //密闭
    public sealed class MyClass2
    {

    }

    //继承：C#中只能有一个基类，如果继承一个抽象类，则必须实现所继承的所有抽象成员（除非派生类也是抽象的）
    public class MyClass3 : MyClass
    {

    }

    public class MyBase
    {

    }

    //派生类的可访问行不能高于基类
    internal class MyClass4 : MyBase
    {

    }

    internal class MyBase2
    {

    }
    //派生类的可访问行不能高于基类
    //public class MyClass5: MyBase2
    //{

    //}

    interface IMyInterface
    {

    }

    //支持接口
    //所有接口成员都必须在支持该接口的类中实现
    public class MyClass6 : IMyInterface
    {

    }

    //继承基类，实现接口顺序：基类,接口,接口，……接口
    //public class MyClass7 : IMyInterface,MyBase
    //{

    //}

    public class MyClass8 : MyBase, IMyInterface
    {

    }

    public interface IMySecondInterface
    {

    }

    public class MyClass9 : MyBase, IMyInterface, IMySecondInterface
    {

    }

    //不能在接口中使用abstract和sealed
    //接口继承：接口,接口,……,接口
    interface IMyInterface2 : IMyInterface, IMySecondInterface
    {

    }

    class MyClass11
    {
        //构造函数
        public MyClass11()
        {

        }

        //也可以使用private修饰
        //private MyClass11()
        //{

        //}

        public MyClass11(int myInt)
        {

        }

        //析构函数
        ~MyClass11()
        {

        }
    }
}
