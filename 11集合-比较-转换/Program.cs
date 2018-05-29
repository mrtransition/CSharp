﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11集合_比较_转换
{
    /*
     * ·如何定义和使用集合
     * ·可以使用的不同类型的集合
     * ·如何比较类型，如何使用is运算符
     * ·如何比较直，比较重载运算符
     * ·如何定义和使用转换
     * ·如何使用as运算符
     */

    /*
     * OOP高级技术：
     * ·集合：可以使用集合来维护对象组
     * ·比较：处理对象时，常常需要比较他们
     * ·转换：如何定制类型转换，以满足自己的要求
     */
    /*
     * 数组：一旦创建好数组，他们的大小就固定，不能在现有数组的末尾田间新项
     * OOP技术可以创建在内部执行大多数此类处理的类，简化了是使用项列表或数组的代码
     * C#中数组实现为System.Array类的实例
     * 他们只是集合类中的一种类型
     * 集合类一般用于处理对象列表，功能比简单数组要多
     * 功能大多是通过实现System.Collections命名空间中的接口而获得的
     * 因此集合的语法已经标准化了。 
     */

    /*
     * 集合的功能可以通过接口实现：
     * 优点：
     * ·定制的集合类可以强类型化；
     * ·提供专用的方法
      */

    /*
     * System.Collections名称空间中的几个接口提供了基本的组合功能：
     * ·IEnumerable可以迭代集合中的项
     * ·ICollection(继承于IEnumerabled)可以获取集合中项的个数，并能把项赋值到一个简单的数组类型中。
     * ·IList(继承于IEnumerable和ICollection)提供了集合的项列表，允许访问这些项，并提供其他一些与项列表相关的基本功能。
     * ·IDictionary(继承于IEnumerable和ICollection)类似于IList，但提供了可以通过键值(而不是索引)访问的项列表。
     */
    //System.Array类实现IList、ICollection和IEnumerable，但不支持IList一些高级功能，它表示大小固定的项列表。

    //System.Collections.ArrayList实现了IList,ICollection和IEnumerable接口，可以用于表示大小可变的项列表


    /*
     * 除了IList集合外，集合还可实现类似的IDictionary接口,允许通过关键值（如字符串名）进行索引，而不是通过一个索引。
     * 这个也可以使用索引符来完成，但这次的索引符参数是与存储的项相关联的关键字，而不是int索引
     * 
     * 可以使用一个基类简化IDictionary接口的实现
     * DictionaryBase:实现了IEnumerable和ICollection，提供了对任何集合都相同的基本集合处理功能
     * DictionaryBase与CollectionBase一样，实现通过其支持的接口获得的一些成员（不是全部成员）
     * DictionaryBase也实现Clear和Count成员，但不实现RemoveAt()。这是因为RemoveAt()是IList接口的一个方法，不是IDictionary接口的方法。
     * IDictionary有一个Remove()方法
     */

    /*
     * 迭代器
     * IEnumerable接口负责使用foreach循环
     * 重写使用foreach循环的方式，或者提供定制的实现方式，并不一定简单
     * foreach循环中，迭代集合cllectionObject的过程如下：
     * 1>调用collectionObject.GetEnumerator(),返回一个IEnumeator引用
     * 2>调用所返回的IEnumerator接口的MoveNext()方法
     * 3>如果MoveNext()方法返回true,就是用IEnumberator接口的Current属性获取对象的一个引用，用于foreach循环
     * 4>重复前面两步，直到MoveNext()方法返回false为止，此时循环停止。 
     * 
     * 使用迭代器将有效地在后台生成许多代码，正确的完成所有任务。
     * 迭代器：它是一个代码块，按顺序提供了要在foreach循环中使用的所有值。一般情况下，这个代码块是一个方法，
     * 但也可以使用属性访问器和其他代码作为迭代器。
     * 
     * 无论代码块是什么，其返回类型都是有限制的。
     * 与期望正好相反，这个返回类型与所枚举的对象典型不同。
     * 例如，在表示Animal对象集合的类中，迭代器块的返回类型不可能是Animal。
     * 两种可能的返回类型是：接口类型IEnumerable和IEnumerator
     * 使用这两个类型场合是：
     * ·如果要迭代一个类，可使用方法GetEnumerator(),其返回类型是IEnumerator
     * ·如果要迭代一个类成员，例如一个方法，则使用IEnumerable
     * 在迭代器块中，使用yield关键字选择要在foreach循环中使用的值。
     * 语法:yield return <value>;
     * 多个返回值类型需一致。
     * yield 返回object类型的值
     * yield 语句可以返回任意类型
     * 
     * 中断信息返回：yield break;
     */

     /*
      * 浅表复制：MemberwiseClone();
      * 深复制：实现ICloneable接口，该接口有一个方法Clone();
      */

     /*
      * 封箱拆箱：
      * 封箱：把值类型转换为System.Object类型或者转换为由值类型实现的接口类型；
      * 拆箱：是相反的过程
      * 注意：在访问值类型内容前，必须进行拆箱
      * 
      * is运算符:是否可转换为
      * is运算符并不是说明对象是某种类型的一种方式，而是可以检查对象是否是给定类型，或者是
      * 否可以转换为给定类型，如果是，这个运算符就返回true.
      * GetType()方法和typeof()运算符很难做到这一点。
      * 语法：<operand> is <type>
      * ·如果<type>是一个类类型，而<operand>也是该类型，或者它继承了该类型，或者它可以封箱到该类型中，则结果为true.
      * ·如果<type>是一个接口类型，而<operand>也是该类型，或者它是实现该接口的类型，则结果为true.
      * ·如果<type>是一个值类型，而<operand>也是该类型,或者它可以拆箱到该类型中，则结果为true.
      */

        /*
         * 值比较：
         * ·运算符重载
         * ·使用IComparable和IComparer接口，是对集合中对象进行排序的一种绝佳方式。
         * 
         * 要重载运算符可以给类添加运算符类型成员，它们必须是static。
         * 一些运算符有多种用途(如-运算符就有一元和二元两种功能)，因此还只能怪了要处理多个操作数，以及这些操作数的类型。
         * 应注意不要把签名相同的运算符添加到多个类中。
         * 如果混合了类型，操作数的顺序必须按照运算符重载的参数顺序相同。
         * 可以重载的运算符：
         * ·一元运算符:+,-,!,++,--,true,false
         * ·二元运算符:+,-,*,/,%,|,^,<<,>>
         * ·比较运算符:==,!=,<,>,<=,>=
         * 不能重载运算符：
         * +=,&&,||,
         * 成对重载
         * <,>
         * 
         * ==,!=常常需要重写Object.Equals()和Object.GetHashCode()，因为这两个函数也可以用于比较对象。
         * 
         * 如果重载true或false运算符，就可以在布尔表达式中使用类,例如，if(op1){}
         */

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
