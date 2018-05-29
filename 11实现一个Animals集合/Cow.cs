using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11实现一个Animals集合
{
    public class Cow : Animal
    {
        public void Milk()
        {
            Console.WriteLine("{0} has been milked", name);
        }

        public Cow(string newName) : base(newName)
        {

        }
    }
}
