using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12泛型
{
    class Program
    {
        /*
         * 泛型：对应C++中的模板
         * 
         * 泛型类是以实例化过程中提供的类型或类为基础建立的，可以毫不费力地对
         * 对象进行强类型化
         * 
         *
         * CollectionClass items = new CollectionClass();
         * items.Add(new ItemClass());
         * 上述代码可以用
         * CollectionClass<ItemClass> items = new CollectionClass<ItemClass>();
         * items.Add(new ItemClass());
         * 代替。
         * 
         * 尖括号语法就是把类型参数传送给泛型类型的方式。
         * 
         * 泛型允许灵活地创建类型，处理一种或多种特定类型的对象，这些类型是在实例化时确定的，
         * 否则就使用泛型类型。 
         */


        /*
         * .Net Framework提供的泛型包括System.Collections.Generic名称空间中的类型
         */

        /*
         * 可空类型
         * 值类型（大多数基本类型，例如int,double和所有的结构）
         * 引用类型（string和所有的类）
         * 值类型必须包含一个值，它们可以在声明之后、赋值之前，在未赋值的状态下存在，
         * 但是不能以任何方式使用。而引用类型可以是null。
         * 
         * 有时让值类型为空是很有用的（尤其是处理数据库时），泛型使用System.Nullable<T>类型
         * 提供了值类型为空的一种方式。例如：
         * System.Nullable<int> nullableInt;
         * nullableInt变量可以用友int变量能包含的任意值，还可以拥有值null。
         * 可以编写：nullableInt = null;
         * 等价于：nullableInt = new System.Nullable<int>();
         * 
         * 但与其他任何变量一样，无论是初始化为null(使用上面的语法),还是通过给它赋值来初始化，都不能在
         * 初始化之前使用它。
         * 
         * 可以像测试引用类型一样，测试可空类型，判断是否为null
         * if(nullableInt == null)
         * {
         *  ...
         * }
         * 也可以使用HasValue属性
         * 如果HasValue是true，说明Value属性有一个非空值
         * 如果HasValue是false，说明变量被赋予了null,访问
         * Value属性会抛出System.InvalidOperationException类型的异常。
         * if(nullableInt.HasValue)
         * {
         *  ...
         * }
         * HasValue不适用于引用类型，即使引用类型有一个HasValue属性，也不能使用这种方法，
         * 因为引用类型的变量值为null,就表示不存在对象，当然就不能通过对象来访问这个属性，否则
         * 会抛出一个异常。
         * 
         * 声明可空类型的变量不使用上述语法，而使用下面的语法：
         * int? nullableInt;
         * 
         * int?是System.Nullable<int>的缩写。
         */

        /*
         * 正确：
         * int? op1 = 5;
         * int? result = op1 * 2;
         * 
         * 错误：
         * int? op1 = 5;
         * int result = op1 * 2;
         * 
         * 必须进行显示转换
         * int? op1 = 5;
         * int result = (int)op1 * 2;
         * 
         * 或者使用Value属性
         * int? op1 = 5;
         * int result = op1.Value * 2;
         * 如果op1是null,则会产生System.InvalidOperationException类型的异常。
         */

        /* int? op1 = null;
         * int? op2 = 5;
         * int? result = op1 * op2;
         * 对于除了bool?之外的所有简单可空类型，上述操作的结果都是null,
         */

        /*
         * ??运算符
         * 为了进一步减少处理可空类型所需要的代码量，使可空变量的处理变的更简单，可以使用??运算符。
         * 这个运算符称为 空接合运算符，是一个二元运算符，允许给可能等于null的表达式提供另一个值。
         * 如果第一个操作数不是null，该运算符就等于第一个操作数，否则，运算符就等于第二个操作数。
         * 一下两个表达式的作用是相同的：
         * op1??op2
         * op1 == null?op2:op1;
         * 
         * op1可以是任意可空表达式，包括引用类型和可空类型。
         * 因此如果可空类型是null，就可以使用??运算符提供要使用的默认值。
         * int? op1 = null;
         * int result = op1 * 2 ?? 5;
         * 在处理中放入int类型的变量result不需要显示转换，??运算符会自动处理这个转换。
         * 也可以：
         * int? result = op1 * 2 ?? 5;
         */

        /*
         * System.Collections.Generic名称空间其中两个类型
         * ·List<T> :T类型对象的集合
         * ·Dictionary<K,V> :与K类型的键值相关的V类型的项的集合
         * 
         * List<T>
         * List<T>泛型集合类型更加快捷、更易使用；不必从CollecitonBase中派生一个类，然后实现需要的方法。
         * 它的另一个好处是正常情况下需要实现的许多方法（例如Add())已自动实现了。
         * 
         * 创建T类型对象的集合需要如下代码：
         * List<T> myCollection = new List<T>();
         * 这个语法实例化的对象支持如下方法和属性
         * int Count;
         * void Add(T item);
         * void AddRange(IEnumberable<T>)
         * IList<T>AsReadOnly()
         * int Capacity
         * void Clear()
         * bool Contains(T item)
         * void CopyTo(T[] array,int index)
         * IEnumberator<T>GetEnumberator()
         * int IndexOf(T item)
         * void Insert(int index,T item)
         * bool Remove(T item)
         * void RemoveAt(int index)
         * 
         * List<T>还有一个Item属性，允许进行类似于数组的访问，如下：
         * T itemAtIndex2 = myCollectionOfT[2];
         */

        /*
         * List<T>排序
         * 泛型接口IComparer<T>和IComparable<T>
         * int IComparable<T>.CompareTo(T otherObj)
         * bool IComparable<T>.Equals(T otherObj)
         * int IComparer<T>.Compare(T objectA,T objectB)
         * bool IComparer<T>.Equals(T objectA,T objectB)
         * int IComparer<T>.GetHashCode(T objectA)
         */
        /*两个可以使用的泛型委托类型：
         * ·Comparision<T>:这个委托类型用于排序方法，其返回类型和参数如下：
         * int method(T objectA,T objectB)
         * ·Predicate<T>:这个委托类型用于搜索方法，其返回类型和参数如下：
         * bool method(T targetObject)
         * 
         * 
         * Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare)
         * route.Sort(sorter);
         * 可以用一下替换：
         * route.Sort(VectorDelegates.Compare);
         * 这样就不需要显示引用Comparison<Vector>类型了，实际上，仍会创建这个类型的一个实例，
         * 但它是隐式创建的。
         * 对VectorDelegates.Compare()的引用(没有括号)成为方法组。
         * 在许多情况下，都可以使用方法组以这种方式隐式地创建委托，使代码变得更容易读取。
         */

        /*
         * Dictionary<K,V>
         * 这个类型可以定义键/值对的集合。
         * 这个类需要实例化两个类型，分别用于键和值，以表示集合中的各个项。
         * 调用示例：
         * foreach(string key in things.Keys)
         * {
         *     Console.WriteLine(key);
         * }
         * 
         * foreach(int value in things.Values)
         * {
         *     Console.WriteLine(value);
         * }
         * 
         * foreach(KeyValuePair<string,int> thing in things)
         * {
         *      Console.WriteLine("{0} = {1}",thing.Key,thing.Value);
         * }
         * 
         * 对于Dictionary<K,V>：每一项的键都必须是唯一的。
         * 如果要添加的项的键与已有项的键相同，就会抛出ArgumentException异常。
         * Dictionary<K,V>允许把IComparer<K>接口传递给其构造函数，如果要把自己的类
         * 用作键，且它们不支持IComparable或IComparable<K>接口，或者要使用非默认的过程比较对象，
         * 就必须把IComparer<K>接口传递结其构造函数。
         */

        /*
         * 定义泛型类型
         * 语法：
         * class MyGenericClass<T>
         * {
         *  ...
         * }
         * 其中T可以是任意标识符，只要遵循通常的C#命名规则即可。
         * 泛型类可以在其定义中包含任意多个类型，它们用逗号分隔开。
         * class MyGenericClass<T1,T2,T3>
         * {
         *  ...
         * }
         * 定义这些类型后，就可以在类定义中项使用其他类型那样使用它们。
         * 可以把它们用作成员变量的类型、属性或方法等成员的返回类型以及方法变元的
         * 多参数类型等。
         * class MyGenericClass<T1,T2,T3>
         * {
         *      private T1 innerT1Object;
         *      public MyGenericClass(T1 item)
         *      {
         *          innerT1Object = item;
         *      }
         *      
         *      public T1 InnerT1Object
         *      {
         *          get
         *          {
         *              return innerT1Object;
         *          }
         *      } 
         * }
         * 
         * 注意：不能假定类提供了什么类型。
         * 
         * 下述代码会出现异常。
         * public MyGenericClass()
         * {
         *      innerT1Object = new T1();
         * }
         * 
         * T1假设：可以把它看作继承自System.Object的类型或可以封箱到System.Object中的类型。
         * 
         * 注意：在比较为泛型类型提供的类型值与null时，只能使用运算符==和!=。
         * 
         * public bool Compare(T1 op1,T1 op2)
         * {
         *      if(op1 != null && op2 != null)
         *      {
         *          return true;
         *      }
         *      
         *      return false;
         * }  
         */

        /*
         * default关键字
         * 要确定用于创建泛型类实例的类型，需要了解一个最基本的情况：
         * 它们时引用类型还是值类型。
         * 
         * 如果不知道这个情况，就不能使用下面的代码赋予null值
         * pubic MyGenericClass()
         * {
         *      innerT1Object = null;
         * }
         * 
         * 所有使用default关键字
         * public MyGenericClass()
         * {
         *      innerT1Object = default(T1);
         * }
         * 其结果是：如果innerT1Object是引用类型，就赋予null值；
         *          如果是值类型，就赋值默认值。 
         */

        /*
         * 约束类型
         * 前面用于泛型类的类型成为无绑定类型，因为没有对它们进行任何约束。
         * 而通过约束类型，可以限制可用于实例化泛型类的类型。
         * 代码是正确的：MyGenericClass<Cow> = new MyGenericClass<Cow>()；
         * 无法编译：MyGenericClass<string> = new MyGenericClass<string>();
         * 
         * 在类定义中，可以使用where关键字实现：
         * class MyGenericClass<T> where T :constraint
         * {
         *  ...
         * } 
         * 其中constraint定义了约束。
         * 可以用这种方式提供许多约束，各个约束间用逗号隔开：
         * class MyGenericClass<T> where T :constraint1,constraint2
         * {
         *  ...
         * }
         * 
         * 还可以使用多个where语句，定义泛型类需要的任意类型或所有类型上的约束：
         * class MyGenericClass<T1,T2> where T1 :constrait1 where T2 : constraint2
         * {
         *  ...
         * }
         * 
         * 约束必须出现在继承说明符后面：
         * class MyGenericClass<T1,T2> : MyBaseClass, IMyInterface
         *      where T1 :constraint1 where T2 :constraint2
         * {
         *    ...  
         * }
         * 
         * 一些可用的约束：
         * struct 类型必须是值类型
         * class 类型必须是引用类型
         * base-class 类型必须是基类或继承自基类。可以给这个约束提供任意类名
         * interface 类型必须是接口或实现了接口
         * new()  类型必须是一个公共的无参数构造函数
         * 如果用new()用作约束，它就必须是为类型指定的最后一个约束。
         * 
         * 可以通过base-class约束，把一个类型参数用作另一个类型参数的约束：
         * class MyGenericClass<T1,T2> where T2 : T1
         * {
         *  ...
         * }
         * 其中，T2必须与T1的类型相同或者继承自T1。
         * 这称为：裸类型约束：表示一个泛型类型参数用作另一个类型参数的约束。
         * 类型约束不能循环。 
         * 
         */

         /*
          * 从泛型类继承
          * 1、如果某个类型所继承的基类型中受到了约束，该类型就不能解除约束。
          * 即：类型T所继承的基类型中使用时，该类型必须受到至少与基类型相同的约束。
          * 2、如果继承了一个反类型，就必须提供所有必须的类型信息，这可以使用其他泛型
          * 类型参数的形式来提供，也可以显示提供。这个也适用于继承了泛型类型的非泛型类。
          * 如：
          * 正确：
          * public class Cards : List<Card>,ICloneable
          * {}
          * 
          * 错误：
          * public class Cards : List<T>,ICloneable
          * {}
          */
          /*
           * 泛型运算符
           * 在C#中，可以像其他方法一样进行运算符重写，这也可以在泛型类中实现此类重写
           * public static implicit operator List<Animal>(Farm<T> farm)
           * {
           *    ...
           * }
           * public static Farm<T> operator +(Farm<T> farm1,List<T> farm2)
           * {
           *    ...
           * }
           * 
           * 
           * 泛型结构
           * public struct MyStruct<T1,T2>
           * {
           *    public T1 item1;
           *    public T2 items;
           * }
           */
        static void Main(string[] args)
        {
        }
    }
}
