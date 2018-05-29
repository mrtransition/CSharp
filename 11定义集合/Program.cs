using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11定义集合
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*
     * 创建自己的、强化型的集合
     * ·手动执行需要的方法
     * ·从类中派生：System.Collections.CollectionBase类
     */
    /*
     * CollectionBase类
     * ·有接口IEnumerable、ICollection和IList
     * IList的Clear()和RemoveAt()
     * ICollection的Count属性
     * ·受保护的属性：List和InnerList
     * ·List可以通过IList接口访问项
     * ·InnerList则用于存储项的ArrayList对象
     */

    public class Animal
    {
        public void Feed()
        {

        }

    }

    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            //使用IList接口中用于访问项的标准Add()方法。
            List.Add(newAnimal);
        }

        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }

        public Animals()
        {

        }

        //CollectionBase类可以对派生的集合使用foreach语法
        /*
        Console.WriteLine("Using custom collection class Animals:");
        Animals animalCollection = new Animals();
        animalCollection.Add(new Cow("Sarah"));
        foreach(Animal myAnimal in animalCollection)
        {
            Console.WriteLine("New {0} object added to custom collection," +
                             "Name = {1}", myAnimal.ToString(),myAnimal.Name);
        } 
         */

        /*
         *索引符：一种特殊类型的属性，可以把它添加到一个类中，以提供类似于数组的访问
         * 
         */

        //在Animal对象的Animalss集合中添加一个索引符
        public class Animalss : CollectionBase
        {
            public Animal this[int animalIndex]
            {
                get
                {
                    //需要进行显示数据类型转换，因为IList.List属性返回一个System.Object对象
                    //强类型化功能意味着可以使用下述代码：
                    //animalCollection[0].Feed();
                    //而不是：
                    //((Animal)animalCollection[0]).Feed();
                    return (Animal)List[animalIndex];
                }
                set
                {
                    List[animalIndex] = value;
                }
            }
        }
    }
}
