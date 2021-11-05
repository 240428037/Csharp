using System;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student() { ID=1,Name="Tim"};//声明变量-Student stu1+创建实例-new Stundet()//初始化器-{}
            //Console.WriteLine(stu1.ID);
            //Console.WriteLine(stu1.Name);
            //stu1.Report();
            //#默认构造器
            //Student stu2 = new Student();//0
            //Console.WriteLine(stu2.ID);
            //Console.WriteLine(stu2.Name);//I'm #0 student,my name is
            //stu2.Report();
            //#实例构造器
            //Student stu3 = new Student(1, "Tim");
            //Console.WriteLine(stu3.ID);
            //Console.WriteLine(stu3.Name);
            //stu3.Report();
            ////@此处调用析构器
            //#不用new操作符创建实例-反射
            //Type t = typeof(Student);//t引用了一个类型类
            //object o = Activator.CreateInstance(t, 1, "Tim");
            ////Console.WriteLine(o.GetType().Name);//Student
            ////Console.WriteLine(o is Student);//True
            //##找回类型-强转/as
            //Student stu4 = (Student)o;
            //Student stu5 = o as Student;
            //Console.WriteLine(stu4.Name);
            //Console.WriteLine(stu5.ID);
            //#dynamic编程
            //Type t=typeof(Student);
            //dynamic stu6 = Activator.CreateInstance(t, 1, "Tim");
            //Console.WriteLine(stu6.Name);
            //#静态构造器
            //Console.WriteLine(Student.Amount);//100
            //Student s1 = new Student(1, "Tim");
            //Student s2 = new Student(2, "Tom");
            //Console.WriteLine(Student.Amount);//析构器被调用两次
        }
    }
    class Student
    {
        //prop属性
        public int ID { get; set; }
        public string Name { get; set; }
        public static int Amount { get; set; }
        public void Report()
        {
            //Console.WriteLine($"I'm #{this.ID} student,my name is{this.Name}");//C#6新语法-字符串解析//this可以省略
            Console.WriteLine("I'm #{0} student,my name is {1}.",this.ID,this.Name);//this可以省略
        }
        //默认构造器
        //ctor
        //实例构造器-无返回值
        public Student(int id,string name)
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }
        //静态构造器-只能用来构造静态成员
        static Student()
        {
            Amount = 100;
        }
        //实例析构器
        ~Student()
        {
            Console.WriteLine("Bye bye!Release the system resources...");
            Amount--;
        }
    }
}
