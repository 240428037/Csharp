using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloOOP
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Type t = typeof(Car);
//            //Type tb = t.BaseType;
//            //Type tTop = tb.BaseType;
//            //Console.WriteLine(tb.FullName);//HelloOOP.Vehicle
//            //Console.WriteLine(tTop.FullName);//System.Object
//            //Console.WriteLine(tTop.BaseType==null);//True
//            //#是一个is a
//            //Car car = new Car();
//            //Console.WriteLine(car is Vehicle);//True
//            //Console.WriteLine(car is object);//True
//            //Vehicle vehicle = new Vehicle();
//            //Console.WriteLine(vehicle is Car);//False
//            //#可以用一个父类类型的变量来引用一个子类类型的实例
//            //Vehicle vehicle = new Car();
//            //Object o1 = new Vehicle();
//            //Object o2 = new Car();
//        }
//    }
//    class Vehicle
//    {
//    }
//    class Car : Vehicle
//    {
//    }
//}



namespace HelloAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Tim");
            Console.WriteLine(car.Owner);//Car Owner//先调用父类的构造器,再调用子类的构造器

        }
    }
    class Vehicle
    {
        public Vehicle(string owner)
        {
            this.Owner =owner;
        }
        public string Owner { get; set; }
    }
    class Car : Vehicle
    {
        //public Car():base("N/A")
        //{
        //    this.Owner = "Car Owner";
        //}
        //#or
        public Car(string owner):base(owner)
        {
            //因为在基类构造器里已经把Owner的值设置为owner参数的值了,
            //所以我们不必要再Car的构造器里再设置一遍了
            //让Car的构造器空着就可以了
        }
        public void ShowOwner()
        {
            //Console.WriteLine(this.Owner);
            //Console.WriteLine(base.Owner);//base关键字只能向上访问一层,只能访问上一级基类的对象//此处的base和this一样
            Console.WriteLine(Owner);
        }
    }
}