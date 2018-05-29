using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11实现一个Animals集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Jack"));
            animalCollection.Add(new Chicken("Vera"));
            foreach(Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
