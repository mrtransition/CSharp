using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13其他OOP技术
{
    class Program
    {
        /*其他OOP技术：
         * · ::运算符
         * · 全局名称空间限定符
         * · 如何创建定制异常
         * · 如果使用事件
         * · 如何使用匿名方法
         */

        /*
         * ::运算符：提供了另一种访问名称空间中类型的方式。
         * 如果要使用一个名称空间的别名，但该别名与实际名称空间层次结构之间的界限不清晰，这将是必须的。
         * 在这种情况下，名称空间层次结构优先于名称空间别名。
         * 
         * using MyNamespaceAlias = MyRootNamespace.MyNestedNamespace;
         * 
         * namespace MyRootNamespace
         * {
         *   namespace MyNamespaceAlias
         *   {
         *      public class MyClass
         *      {}
         *   }
         *   
         *   namespace MyNestedNamespace
         *   {
         *      public class MyClass
         *      {}
         *   } 
         * }
         * 
         * MyNamespaceAlias.MyClass
         * 表示类是MyRootNamespace.MyNamespaceAlias.MyClass类，而不是MyRootNamespace.MyNestedNamespace.MyClass类。
         * 也就是说，MyRootNamespace.MyNamespaceAlias名称空间隐藏了由using语句定义的别名。
         * MyNestedNamespace.MyClass
         * 表示MyRootNamespace.MyNestedNamespace.MyClass
         * 也可以使用MyNamespaceAlias::MyClass
         * 使用这个运算符会会迫使编译器使用由using语句定义的别名。
         * 
         * ::运算符还可以和global关键字一起使用，它实际上是顶级根名称空间的别名。
         * global::System.Collections.Generic.List<int>
         */

        /*
         * 定制异常
         * try...catch...finally
         * 调试->异常->添加
         */

        /*
         * 事件：类似于异常，因为它们都是由对象引发（抛出）,我们可以提供代码来处理事件。
         * 事件必须订阅：订阅一个事件的含义是提供代码，在事件发生时执行这些代码，它们称为事件处理程序。
         * 
         * 单个事件可供多个处理程序订阅，在该事件发生时，这些处理程序都会被调用，其中包括引发该事件的
         * 对象所在的类中的事件处理程序，但事件处理程序也可能在其他类中。
         * 事件处理程序本身都是简单的方法。对事件处理方法的唯一限制时它必须匹配于事件所需求的返回类型和参数。
         * 关键字：+=
         * 在定义事件前，必须先定义一个委托类型，以用于该事件，这个委托类型指定了事件处理方法必须拥有的返回类型和参数。
         * 
         */

        /*
         * 匿名方法
         * 它不是某个类上的方法，而纯粹时为用作委托目的而创建的。
         * 对于匿名方法要注意，对于包含它们的代码块来说，它们是局部的，可以访问这个区域内的局部变量。
         * 如果使用这样一个变量，它就成为外部变量。外部变量在超出作用域时，是不会删除的，这与其他局部变量不同，
         * 在使用它们的匿名方法被销毁时，外部变量才会删除。
         * 
         */
        static void Main(string[] args)
        {
        }
    }
}
