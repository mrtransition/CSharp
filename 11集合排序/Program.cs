using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11集合排序
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Person("Jim", 30));
            list.Add(new Person("Bob", 25));
            list.Add(new Person("Bert", 27));
            list.Add(new Person("Ernie", 22));

            Console.WriteLine("Unsorted people:");
            for(int i = 0; i<list.Count;i++)
            {
                Console.WriteLine("{0} ({1})",
                    (list[i] as Person).Name,(list[i] as Person).Age);
            }
            Console.WriteLine();

            Console.WriteLine(
                "People sorted with defualt comparer (by age):");
            list.Sort();
            for(int i = 0; i< list.Count;i++)
            {
                Console.WriteLine("{0} ({1})",
                    (list[i] as Person).Name,(list[i] as Person).Age);
            }

            Console.WriteLine();

            Console.WriteLine(
                "People sorted with nondefault comparer (by name):");
            list.Sort(PersonComparerName.Default);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0} ({1})",
                    (list[i] as Person).Name, (list[i] as Person).Age);
            }

            Console.ReadKey();

        }
    }

    class Person : IComparable
    {
        public string Name;
        public int Age;

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            if(obj is Person)
            {
                Person otherPerson = obj as Person;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException(
                    "Object to compare to is not a Person object.");
            }
        }
    }

    public class PersonComparerName : IComparer
    {
        public static IComparer Default = new PersonComparerName();
        
        public int Compare(object x,object y)
        {
            if(x is Person && y is Person )
            {
                return Comparer.Default.Compare(((Person)x).Name,((Person)y).Name);
            }
            else
            {
                throw new ArgumentException(
                    "One or both objects to compare are not Person objects.");
            }
        } 
    }
}
