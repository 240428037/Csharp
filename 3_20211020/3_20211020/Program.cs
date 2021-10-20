using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person persion1 = new Person();
//            Person persion2 = new Person();
//            persion1.Name = "Deer";
//            persion2.Name = "Deer's wife";
//            //List<Person> nation = Person.GetMarry(persion1, persion2);
//            List<Person> nation = persion1 + persion2;
//            foreach (var p in nation)
//            {
//                Console.WriteLine(p.Name);
//            }
//        }
//    }
//    class Person
//    {
//        public string Name;
        
//        //public static List<Person> GetMarry(Person p1, Person p2)
//        public static List<Person>operator +(Person p1, Person p2)
//        {
//            List<Person> people = new List<Person>();
//            people.Add(p1);
//            people.Add(p2);
//            for (int i = 0; i < 11; i++)
//            {
//                Person child = new Person();
//                child.Name = p1.Name + "&" + p2.Name + "s child";
//                people.Add(child);
//            }
//            return people;
//        }
//    }
//}





//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 1;
//            int y = 2;
//            int z = 3;
//            //+=为赋值运算符,运算顺序由右向左
//            x += y += z;
//            Console.WriteLine(x);//6
//            Console.WriteLine(y);//5
//            Console.WriteLine(z);//3
//        }
//    }
//}

////x.y
//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //1.访问外层命名空间的子集命名空间
//            //2.访问命名空间中的类型
//            //3.访问类型的静态成员
//            //System.IO.File.Create("D:\\hello.txt");
//            //4.访问对象的成员
//            Form form = new Form();
//            form.Text = "hello";
//            form.ShowDialog();
//        }
//    }
//}

//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator c = new Calculator();
//            //double x = c.Add(3.0, 5.0);
//            //Console.WriteLine(x);
//            //即使方法无参,也不能省略方法调用操作符()
//            //c.PrintHello();
//            //委托
//            Action myAciton = new Action(c.PrintHello);
//            myAciton();

//        }
//    }
//    class Calculator
//    {
//        public double Add(double a, double b)
//        {
//            return a + b;
//        }
//        public void PrintHello()
//        {
//            Console.WriteLine("hello");
//        }
//    }
//}





//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //数组
//            int[] myIntArray = new int[] { 1, 2, 3, 4, 5 };//{}-初始化器,[]内数字可省略,如果写只能是5,否则编译不通过
//            Console.WriteLine(myIntArray[0]);
//            Console.WriteLine(myIntArray.Length - 1);//array[4],5-1=4
//            //字典
//            //Dictionary<>,有<>说明为泛型类
//            //<索引,值>
//            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
//            for (int i = 1; i <= 100; i++)
//            {
//                Student stu = new Student();
//                stu.Name = "s_" + i.ToString();
//                stu.Score = 100 + i;
//                stuDic.Add(stu.Name, stu);
//            }
//            Student number6 = stuDic["s_6"];
//            Console.WriteLine(number6.Score);//106
//        }
//    }
//    class Student
//    {
//        public string Name;
//        public int Score;
//    }
//}


//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //
//            Type t = typeof(int);
//            Console.WriteLine(t.Namespace);//System
//            Console.WriteLine(t.FullName);//System.Int32
//            Console.WriteLine(t.Name);//Int32
//            int c = t.GetMethods().Length;
//            foreach (var mi in t.GetMethods())
//            {
//                Console.WriteLine(mi.Name);
//            }
//            Console.WriteLine(c);
//        }
//    }
//}

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //结构体类型-int double
            int x = default(int);
            Console.WriteLine(x);//0
            //引用类型
            Form form = default(Form);
            Console.WriteLine(form==null);//True
            //枚举类型
            Level1 level1 = default(Level1);
            Console.WriteLine(level1);//Low
            Level2 level2 = default(Level2);
            Console.WriteLine(level2);//Mid
        }
    }
    enum Level1
    {
        Low,//0
        Mid,//1
        High//2
    }
    //自己显示赋值的时候必须要给一个0,否则会出问题
    enum Level2
    {
        Low=1,
        Mid=0,
        High=3
    }
}