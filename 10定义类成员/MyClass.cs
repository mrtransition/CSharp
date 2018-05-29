using System;

namespace _10定义类成员
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;

        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 10 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value,
                        "Val must be assigned a value betweent 0 and 10."));
            }
        }

        public override string ToString()
        {
            return "Name:" + Name + "\nVal:" + Val;
        }

        private MyClass() : this("Default Name")
        {
        }
        public MyClass(String newName)
        {
            Name = newName;
            intVal = 0;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Create object myObj...");
            MyClass myObj = new MyClass("My Object");
            Console.WriteLine("myObj created.");
            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine("\nAttempting to assign{0} to myObj.Val...", i);
                    myObj.Val = i;
                    Console.WriteLine("Value{0} assigned to myObj.Val.", myObj.Val);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception{0} thrown.", e.GetType().FullName);
                    Console.WriteLine("Message:\n\"{0}\"", e.Message);
                }
                Console.WriteLine("\nOutputting myObj.ToString()...");
                Console.WriteLine(myObj.ToString());
                Console.WriteLine("myObj.ToString() Output.");
                Console.ReadKey();
            }
        }

        public void DoSomthing()
        {
            throw new System.NotImplementedException();
        }

        private string strVal;

        public string StrVal1
        {
            get; 
            set;
        }
    }
}
