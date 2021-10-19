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

////namespace _1
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Student stu = new Student();
////            int y = 100;
////            stu.AddOne(y);//101
////            Console.WriteLine(y);//100
////        }
////    }
////    class Student
////    {
////        public void AddOne(int x)
////        {
////            x = x + 1;
////            Console.WriteLine(x);
////        }
////    }
////}


////#
////实际编程很少用
//namespace _2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student stu = new Student() { Name = "Tim" };
//            SomeMethod(stu);//Tom
//            Console.WriteLine(stu.Name);//Tim
//        }
//        static void SomeMethod(Student stu)
//        {
//            stu = new Student() { Name = "Tom" };
//            Console.WriteLine(stu.Name);
//        }
//    }
//    class Student
//    {
//        public string Name { get; set; }
//    }
//}


//namespace _3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student stu = new Student() { Name = "Tim" };
//            SomeMethod(stu);//46104728,Tim
//            Console.WriteLine("{0},{1}", stu.GetHashCode(), stu.Name);//12289376,Tim
//        }
//        static void SomeMethod(Student stu)
//        {
//            stu = new Student() { Name = "Tim" };
//            Console.WriteLine("{0},{1}", stu.GetHashCode(), stu.Name);
//        }
//    }
//    class Student
//    {
//        public string Name { get; set; }
//    }
//}

////#

////副作用,side-effect
//namespace _4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student stu = new Student() { Name = "Tim" };
//            UpdateObject(stu);//一样
//            Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);//一样
//        }
//        static void UpdateObject(Student stu)
//        {
//            stu.Name = "Tom";
//            Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
//        }
//    }
//    class Student
//    {
//        public string Name { get; set; }
//    }
//}




//namespace _5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int y = 1;
//            IWantSideEffect(ref y);
//            Console.WriteLine(y);//101
//        }
//        static void IWantSideEffect(ref int x)
//        {
//            x = x + 100;
//        }
//    }
//}



//namespace _6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student outterStu = new Student() { Name = "Tim" };
//            Console.WriteLine("HashCode={0},Name={1}", outterStu.GetHashCode(), outterStu.Name);//HashCode=46104728,Name=Tim
//            Console.WriteLine("——————————");
//            IWantSideEffect(ref outterStu);//HashCode=12289376,Name=Tom
//            Console.WriteLine("HashCode={0},Name={1}", outterStu.GetHashCode(), outterStu.Name);//HashCode=12289376,Name=Tom
//        }
//        static void IWantSideEffect(ref Student stu)
//        {
//            stu = new Student() { Name = "Tom" };
//            Console.WriteLine("HashCode={0},Name={1}",stu.GetHashCode(),stu.Name);
//        }
//    }
//    class Student
//    {
//        public string Name { get; set; }
//    }
//}


//namespace _7
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            student outterstu = new student() { name = "tim" };
//            console.writeline("hashcode={0},name={1}", outterstu.gethashcode(), outterstu.name);//hashcode=46104728,name=tim
//            console.writeline("——————————");
//            somesideeffect(ref outterstu);//hashcode=46104728,name=tom
//            console.writeline("hashcode={0},name={1}", outterstu.gethashcode(), outterstu.name);//hashcode=46104728,name=tom
//        }
//        static void somesideeffect(ref student stu)
//        {
//            stu.name = "tom";
//            console.writeline("hashcode={0},name={1}", stu.gethashcode(), stu.name);
//        }
//    }
//    class student
//    {
//        public string name { get; set; }
//    }
//}


//namespace _8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please input first number:");
//            string arg1 = Console.ReadLine();
//            double x = 0;
//            bool b1 = double.TryParse(arg1, out x);
//            if (b1==false)
//            {
//                Console.WriteLine("Input error!");
//                return;
//            }

//            Console.WriteLine("Please input second number");
//            string arg2 = Console.ReadLine();
//            double y = 0;
//            bool b2 = double.TryParse(arg2, out y);
//            if (b2==false)
//            {
//                Console.WriteLine("Input error!");
//                return;
//            }

//            double z = x + y;
//            Console.WriteLine("{0}+{1}={2}",x,y,z);
//        }
//    }
//}



//namespace _9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double x = 100;
//            bool b = DoubleParser.TryParse("7A", out x);
//            if (b==true)
//            {
//                Console.WriteLine(x+1);
//            }
//            else
//            {
//                Console.WriteLine(x);
//            }
//        }
//    }
//    class DoubleParser
//    {
//        public static bool TryParse(string input, out double result)
//        {
//            try
//            {
//                result = double.Parse(input);
//                return true;
//            }
//            catch
//            {
//                result = 0;//out参数必须赋值
//                return false;
//            }
//        }
//    }
//}


//namespace _10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student stu = null;
//            bool b = StudentFactory.Create("Tim", 34, out stu);
//            if (b==true)
//            {
//                Console.WriteLine("Student {0},age is {1}",stu.Name,stu.Age);
//            }
//        }
//    }
//    class Student
//    {
//        public int Age { get; set; }
//        public string Name { get; set; }
//    }
//    class StudentFactory
//    {
//        public static bool Create(string stuName, int stuAge, out Student result)
//        {
//            result = null;
//            if (string.IsNullOrEmpty(stuName))
//            {
//                return false;
//            }
//            if (stuAge<20||stuAge>80)
//            {
//                return false;
//            }
//            result = new Student() { Name = stuName, Age = stuAge };
//            return true;
//        }
//    }
//}



//namespace _11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //int[]myIntArray=new int[]{1,2,3};
//            //int result = CalculatorSum(myIntArray);
//            //Console.WriteLine(result);
//            //-
//            //int result = CalculatorSum(1, 2, 3);
//            //Console.WriteLine(result);
//            //-
//            int x = 100;
//            int y = 200;
//            int z = x + y;
//            Console.WriteLine("{0}+{1}={2}",x,y,z);
//            //-
//            string str = "Tim;Tom,Amy.Lisa";
//            string[] result = str.Split(';','.',',');
//            foreach (var name in result)
//            {
//                Console.WriteLine(name);
//            }
//        }
//        static int CalculatorSum(params int[] intArray)
//        {
//            int sum = 0;
//            foreach (var item in intArray)
//            {
//                sum += item;
//            }
//            return sum;
//        }
//    }
//}



//namespace _12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            PrintInfo(age: 34, name: "Tim");
//        }
//        static void PrintInfo(string name, int age)
//        {
//            Console.WriteLine("Hello {0},you are {1}",name,age);
//        }
//    }
//}

//namespace _12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            PrintInfo();
//        }
//        static void PrintInfo(string name="Tim", int age=34)
//        {
//            Console.WriteLine("Hello {0},you are {1}", name, age);
//        }
//    }
//}


//namespace _13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double x = 3.14159;
//            //double y = Math.Round(x, 4);
//            double y = x.Round(4);
//            Console.WriteLine(y);//3.1416
//        }
//    }
//    static class DoubleExtension
//    {
//        public static double Round(this double input, int digits)
//        {
//            double result = Math.Round(input, digits);
//            return result;
//        }
//    }
//}


namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 11, 12, 13, 14, 15 };
            //bool result = AllGreaterThanTen(myList);
            bool result = myList.All(i => i > 10);//
            Console.WriteLine(result);
        }
        static bool AllGreaterThanTen(List<int> intList)
        {
            foreach (var item in intList)   
            {
                if (item <= 10)
                {
                    return false;
                }
            }
            return true;
        }
    }
}