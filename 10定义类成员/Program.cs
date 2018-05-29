using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10定义类成员
{
    class Program
    {
        /*
         * 所有成员都有自己的访问级别：
         * public - 成员可以由任何代码访问
         * private - 成员只能由类中的代码访问（无修饰符时默认为）
         * internal - 成员只能由定义他的程序集（项目）内部的代码访问
         * protected - 成员只能由类或派生类中的代码访问
         * protected internal 只能由程序集中的派生类的代码来访问
         * */
         //.NetFramework中的公共字段以PascalCasing形式命名
         //私有字段通常使用camelCasing形式命名
        public int MyInt;
        //readonly:表示这个字段只能在执行构造函数的过程中赋值，或由初始化赋值语句赋值
        public readonly int MyInt2 = 17;

        //静态字段：不能通过这个类的对象实例来访问，只能通过类来访问
        public static int MyInt3;

        //const静态:不能用static来修饰
        public const int MyInt4 = 18;

        private int myInt; 

        //方法：标准函数格式、可访问性和可选的static修饰符来声明
        //与公共字段一样，.Net中的公共方法也采用PascalCasing形式来命名
        public string GetString()
        {
            return "Here is a string.";
        }

        //如果使用static表示这个方法只能通过类来访问，不能通过对象实例来访问
        /*
         * 可以在方法定义中使用
         * virtual - 方法可重写
         * abstract - 方法必须在非抽象的派生类中重写（只用于抽象类中）
         * override - 方法编写了一个基类方法（如果方法被重写，就必须使用改关键字）
         * extern - 方法定义放在其他地方         
         */

        public class MyBaseClass
        {
            public virtual void DoSomething()
            {
                //Base implementation.
            }

            public virtual void GetSomething()
            {

            }


        }

        public class MyDerivedClass : MyBaseClass
        {
            public override void DoSomething()
            {
                //
            }

            //如果使用了override ，也可以使用sealed指定在派生类中不能对方法作进一步的修改
            //即这个方法不能由派生类重写
            //当应用于方法或属性时，sealed 修饰符必须始终与 override 一起使用。
            public override sealed void GetSomething()
            {
                Console.WriteLine("");
                //base.GetSomething();
            }
        }

        public class MySecondClass:MyDerivedClass
        {
            public override void DoSomething()
            { 
            }

            //sealed修饰：无法继承和重写
            //public override void GetSomething()
            //{

            //}
        }

        /*
         *属性的基本结构包括标准的
         * 可访问修饰符(public、private、protected)，后跟类名、属性名和get块或set块，其中包含属性处理代码
         * 属性可以使用virtual、override和abstract关键字但这几个关键字不能用于字段
         */
         //.Net中公共属性也以PascalCasing方式命名
         public int MyIntProp
        {
            //get块必须有一个属性类型的返回值，
            get
            {
                return myInt;
            }
            //value表示用户提供的属性值
            //value等于类型与属性相同的一个值
            //属性的作用时对操作进行更多的控制
            protected set
            {
               // myInt = value;
                
               if(value >= 0 && value <= 10)
                {
                    myInt = value;
                }
               else
                {
                    //抛出异常：System名称空间的标准异常
                    throw (new ArgumentOutOfRangeException("MyIntProp", value,
                        "MyIntProp must be assigned a value between 0 and 10."));
                }

               /*如果使用了无效值：
                * 1、什么也不做
                * 2、给字段赋默认值
                * 3、继续执行，但记录下该事件，以备将来分析
                * 4、抛出异常
                * 一般情况下，后两个选择效果较好
                * */

            }
        }



    }
}
