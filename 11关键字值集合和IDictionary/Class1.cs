using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11关键字值集合和IDictionary
{
    public class Class1
    {
    }

    public abstract class Animal
    {

    }


    public class Animals : DictionaryBase
    {
        //关键字和一个值
        public void Add(string newID, Animals newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }

        //关键字参数而不是对象引用
        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }

        public Animals()
        { }

        //使用字符串关键字值而不是一个索引
        public Animal this[string animalID]
        {
            get
            {
                return (Animal)Dictionary[animalID];
            }
            set
            {
                Dictionary[animalID] = value;
            }
        }
    }
}
