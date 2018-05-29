using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11Ch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Chicken("John");
            myAnimal.Feed();
            Console.ReadKey();
        }
    }


    public abstract class Animal
    {
        private string name;

        public string Name { get; set; }

        public Animal(){}

        public Animal(string newName)
        {
            name = newName;
        } 

        public void Feed()
        {
            Console.WriteLine("{0} has been feed.", name);
        }
    }

    public class Chicken :Animal
    {
        public Chicken(string newName) : base(newName)
        { }
    }
}
