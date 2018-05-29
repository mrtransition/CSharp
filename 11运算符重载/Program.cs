using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            AddClass1 op1 = new AddClass1();
            op1.Val = 1;
            AddClass1 op2 = new AddClass1();
            op2.Val = 2;
            AddClass1 op3 = op1 + op2;
            Console.WriteLine("op3.Var={0}", op3.Val);


            AddClass2 op4 = new AddClass2();
            op4.Val = 10;
            AddClass3 op5 = op1 + op4;
            Console.WriteLine("op5.Var={0}", op5.Val);

            Console.ReadKey();
        }
    }

    public class AddClass1
    {
        public int Val;

        //重载+
        public static AddClass1 operator +(AddClass1 op1, AddClass1 op2)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.Val = op1.Val + op2.Val;
            return returnVal;
        }

        public static AddClass3 operator +(AddClass1 op1, AddClass2 op2)
        {
            AddClass3 returnVal = new AddClass3();
            returnVal.Val = op1.Val + op2.Val;
            return returnVal;
        }

        public static AddClass1 operator -(AddClass1 op1)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.Val = -op1.Val;
            return returnVal;
        }
    }

    public class AddClass2
    {
        public int Val;
    }

    public class AddClass3
    {
        public int Val;
    }

    public class AddClass4
    {
        public int Val;
        public static bool operator >=(AddClass4 op1, AddClass4 op2)
        {
            return (op1.Val >= op2.Val);
        }

        public static bool operator <(AddClass4 op1, AddClass4 op2)
        {
            //return !(op1.Val >=  op2.Val);
            return !(op1 >= op2); //直接使用上述定义
        }

        public static bool operator <=(AddClass4 op1, AddClass4 op2)
        {
            return (op1.Val <= op2.Val);
        }

        public static bool operator >(AddClass4 op1, AddClass4 op2)
        {
            return (op1.Val > op2.Val);
        }

        //Equals重写不是static
        public override bool Equals(object op1)
        {
            if(op1 is AddClass4)
            {
                return Val == ((AddClass4)op1).Val;
            }
            else
            {
                throw new ArgumentException(
                    "Cannot compare AddClass1 objects with object of type "
                    + op1.GetType().ToString());
            }

            //return Val == ((AddClass1)op1).Val;
        }
        //GetHashCode重写不是static
        public override int GetHashCode()
        {
            return Val;
        }
         
    } 
}
