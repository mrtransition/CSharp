using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11实现一个Animals集合
{
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }

        public Animals()
        {

        }

        public Animal this[int animalIndex]
        {
            get
            {
                return (Animal)List[animalIndex];
            }
            set
            {
                List[animalIndex] = value;
            }
        }
    }
}
