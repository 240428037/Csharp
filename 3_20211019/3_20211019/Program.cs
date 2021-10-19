using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
//            //Student stu = new Student();
//            //Student stu = new Student() { ID=1,Name="Timpthy"};
//            //Console.WriteLine(stu.ID);
//            //Console.WriteLine(stu.Name);
//            //stu.Report();
//            //-
//            ////自定义构造器
//            //Student stu = new Student(1, "Tim");
//            //Console.WriteLine(stu.ID);
//            //Console.WriteLine(stu.Name);
//            //stu.Report();
//            //-
//            //反射
//            //Type t = typeof(Student);//把Student类存储在类型类当中
//            //object o = Activator.CreateInstance(t,1,"Tim");
//            ////Console.WriteLine(o.GetType().Name);
//            ////Console.WriteLine(o is Student);
//            ////Student stu = (Student)o;//1
//            //Student stu = o as Student;//2
//            //Console.WriteLine(stu.Name);
//            //-
//            ////dynamic编程
//            //Type t = typeof(Student);
//            //dynamic stu = Activator.CreateInstance(t, 1, "Tim");
//            //Console.WriteLine(stu.Name);
//            //static构造器
//            //Console.WriteLine(Student.Amount);
//            //-
//            //Amount
//            Student s1 = new Student(1, "Tim");
//            Student s2 = new Student(2, "Tom");
//            Console.WriteLine(Student.Amount);
//        }
//    }
//    class Student
//    {
//        public static int Amount { get; set; }
//        static Student()
//        {
//            Amount = 100;
//        }
//        public Student(int id,string name)
//        {
//            this.ID = id;
//            this.Name = name;
//            Student.Amount++;
//        }
//        ~Student()
//        {
//            Console.WriteLine("Bye------");
//            Amount--;
//        }
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public void Report()
//        {
//            //C#6字符串解析
//            //Console.WriteLine($"I'm #{this.ID}student,my name is{this.Name}.");
//            Console.WriteLine("{0},{1}",ID,Name);
//        }
//    }
//}



namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}