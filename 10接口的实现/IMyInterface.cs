using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10接口的实现
{
    /**
     * ·所有接口成员都是公共的，不允许使用访问修饰符(public、private、protected或internal)
     * ·接口成员不能包含代码体
     * ·接口不能定义字段成员
     * ·接口成员不能使用关键字static、virtual、abstract或sealed来定义
     * ·类型定义成员是禁止的
     */
    interface IMyInterface
    {
        void DoSomething();
    }

    //隐藏继承了基接口的成员，可以使用关键字new来定义它们
    interface IMyDerviedInterface : IMyInterface
    {
        new void DoSomething();
    }

    //在接口中定义的属性可以定义访问块get和set
    interface IMyInterface2
    {
        //get和set可以省略它们中的任一个
        //类似自动属性，但是不是自动属性，自动属性必须包含get和set
        //int MyInt { get; set; }

        //int MyInt { get; }

        int MyInt { set; }
    }

    public interface IMyInterface3
    {
        void DoSomething();
        void DoSomethingElse();
    }
}
