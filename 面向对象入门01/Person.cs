using System; 

namespace 面向对象入门01
{
    public class Person
    {
        static string _name;
        static int _age;
        static string _sex;

        public string Name
        {
            get { return _name; }
            set { _name = value; } 
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("姓名{0}，年龄{1}，性别{2}",_name,_age,_sex);
        }
    }
}