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
//            Student stu = new Student(1);
//            Console.WriteLine(stu.ID);//1
//        }
//    }
//    class Student
//    {
//        public int Age=20;//字段的初始化器
//        public int Score;

//        public static int AverageAge;
//        public static int AverageScore;
//        public static int Amount = 100;//字段的初始化器

//        public readonly int ID;//只读字段
//        public Student(int id)
//        {
//            this.ID = id;
//        }
//    }
//}

//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Student stu1 = new Student();
//                stu1.SetAge(20);
//                Student stu2 = new Student();
//                stu2.SetAge(20);
//                Student stu3 = new Student();
//                stu3.SetAge(200);
//                int avgAge = (stu1.GetAge() + stu2.GetAge() + stu3.GetAge()) / 3;
//                Console.WriteLine(avgAge);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//    class Student
//    {
//        private int age;
//        public int GetAge()
//        {
//            return this.age;
//        }
//        public void SetAge(int value)
//        {
//            if (value>=0&&value<=120)
//            {
//                this.age = value;
//            }
//            else
//            {
//                throw new Exception("Age value has error!");
//            }
//        }
//    }
//}


//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Student stu1 = new Student();
//                stu1.Age = 20;
//                Student stu2 = new Student();
//                stu2.Age = 20;
//                Student stu3 = new Student();
//                stu3.Age = 200;
//                int avgAge = (stu1.Age + stu2.Age + stu3.Age);
//                Console.WriteLine(avgAge);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//    class Student
//    {
//        private int age;
//        public int Age
//        {
//            get
//            { 
//                return age; 
//            }
//            set 
//            {
//                //value-上下文关键字
//                if (value>=0&&value<=120)
//                {
//                    this.age = value;
//                }
//                else
//                {
//                    throw new Exception("Age value has error");
//                }
//            }
//        }
//    }
//}