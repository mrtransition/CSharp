﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12使用List_T
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
