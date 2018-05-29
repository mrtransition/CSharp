using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10部分方法定义
{
    //部分类也可以定义部分方法
    //部分方法在部分类中定义，但没有方法体，在另一个部分类中包含实现代码。
    //在这两个部分类中，都要使用partial关键字
    public partial class MyClass
    {
        partial void MyPartialMethod();
    }

    public partial class MyClass
    {
        partial void MyPartialMethod()
        {
            throw new NotImplementedException();
        }
    }

    //部分方法也可以是静态的，但他们总是私有的，且不能有返回值
    //他们使用的任何参数都不能是out参数，但可以是ref参数
    //部分方法也不能使用vitual、abstract、override、new、sealed和extern修饰符
}
