using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10接口的实现
{
    class MyClass : IMyInterface3
    {
        //可以使用关键字virtual或abstract来实现接口成员
        //不能使用static或const
        public void DoSomething()
        {

        }

        public void DoSomethingElse()
        {

        }
    }

    public class MyBaseClass
    {
        public void DoSomething()
        {

        }
    }

    public class MyDerivedClass :MyBaseClass,IMyInterface3
    {
        //在基类上实现接口成员
        public void DoSomethingElse()
        {

        }
    }

    public class MyBaseClass2 : IMyInterface3
    {
        public virtual void DoSomething()
        {

        }

        public virtual void DoSomethingElse()
        {

        }
    }

    //继承一个实现给定接口的基类，就意味着派生类隐式地支持这个接口
    //在基类中把实现代码定义为虚拟，派生类就可以替换该实现代码，而不是隐藏他们
    public class MyDerivedClass2 : MyBaseClass2
    {
        public override void DoSomething()
        {
            //base.DoSomething();
        }
    }

    public class DoSom
    {
        static void Main(String[] args)
        { //如果类MyClass隐式地实现了接口IMyInterface的方法DoSomething()则下面的代码有效
            MyDerivedClass2 myObj = new MyDerivedClass2();
            myObj.DoSomething();

            //如果隐式实现接口，下述技术也可使用，如果显示实现，只能用下述技术，不能用上述技术
            MyClass4 myobj2 = new MyClass4();
            IMyInterface3 myInt = myobj2;
            myInt.DoSomething();
            //myobj2.DoSomething();
        }
    }

    public class MyClass4 : IMyInterface3
    {
        //显示实现DoSomething
        void IMyInterface3.DoSomething()
        {
            throw new NotImplementedException();
        }

        public void DoSomethingElse()
        {
            throw new NotImplementedException();
        }
    }

    //接口定义的存取器是公共的，实现只能添加非公共的存取器
    interface IMyInterface11
    {
        int MyIntProperty
        { get; }
    }

    public class MyBaseClass11:IMyInterface11
    {
        public int MyIntProperty
        {
            get;
            protected set;  //非public修饰符
        }
    }
}
