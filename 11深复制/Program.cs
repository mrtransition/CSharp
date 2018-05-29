using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11深复制
{
    class Program
    {
        static void Main(string[] args)
        { 
            Cloner mySource = new Cloner(5);
            Cloner myTarget = (Cloner)mySource.GetCopy();
            Console.WriteLine("myTarget.MyContent.Val={0}", myTarget.MyContent.Val); //5
            mySource.MyContent.Val = 2;
            Console.WriteLine("myTarget.MyContent.Var={0}", myTarget.MyContent.Val);

            Cloner2 mySource2 = new Cloner2(5);
            Cloner2 myTarget2 = (Cloner2)mySource2.Clone();
            Console.WriteLine("myTarget2.MyContent.Val={0}", myTarget2.MyContent.Val); //5
            mySource.MyContent.Val = 2;
            Console.WriteLine("myTarget2.MyContent.Var={0}", myTarget2.MyContent.Val);
            Console.ReadKey(); 
        }
    }

    public class Cloner
    {
        public int Val;

        public Content MyContent = new Content();

        public Cloner(int newVal)
        {
            Val = newVal;
            MyContent.Val = newVal;
        }

        public object GetCopy()
        {
            return MemberwiseClone(); //创建浅表赋值
        }
    }

    //假定有引用类型的字段而不是值类型的字段(例如，对象)
    public class Content
    {
        public int Val;
    }

    public class Cloner2:ICloneable
    {
        public Content MyContent = new Content();

        public Cloner2(int newVal)
        {
            MyContent.Val = newVal;
        }

        public object Clone()
        {
            Cloner2 clonedCloner = new Cloner2(MyContent.Val);
            return clonedCloner;
        }
    }

}
