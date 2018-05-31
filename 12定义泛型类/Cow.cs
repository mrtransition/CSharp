using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12定义泛型类
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

        public override void MakeANoise()
        {
            Console.WriteLine("{0} syas 'moo!'", name);
        }
    }
}
