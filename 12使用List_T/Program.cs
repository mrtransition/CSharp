﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12使用List_T
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
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
