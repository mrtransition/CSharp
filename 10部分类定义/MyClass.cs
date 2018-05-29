using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10部分类定义
{
    //如果所创建的类包含一种类型或其他类型的许多成员事，很容易混淆，代码文件比较长，
    //这种情况下采用代码分组方法
    class MyClass
    {
        #region Fields
        private int myInt;
        #endregion

        #region Constructor
        public MyClass()
        {
            myInt = 99;
        }
        #endregion

        #region Properties
        public int MyInt
        { get; set; }
        #endregion

        #region Methods
        public void DoSomething()
        {

        }
        #endregion 
    }

    //使用代码折叠代码也可能难以理解,对此提供一种方法：部分类定义
    //把类的定义放在多个文件中，例如可以把字段、属性和构造函数放在一个文件中，
    //把方法放在另一个文件中
    //关键字：partial
    //部分类定义对windows应用程序隐藏与窗体布局相关代码有很大作用
    public partial class MyClass2
    {

    }

    interface IMyInterface1 { }

    interface IMyInterface2 { }

    public partial class MyClass3 : IMyInterface1
    {

    }

    public partial class MyClass3 : IMyInterface2
    {

    }

    //等价
    public class Myclass3 : IMyInterface1,IMyInterface2
    { }
}
