using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11数组和高级集合
{
    public class Chicken :Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid an egg.",name);
        }

        public Chicken(string newName) :base(newName)
        {

        }
    }
}
