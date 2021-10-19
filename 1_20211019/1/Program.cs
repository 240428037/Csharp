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
//            Calculator calculator = new Calculator();
//            Action action = new Action(calculator.Report);
//            calculator.Report();
//            action.Invoke();
//            action();

//            //Func泛型委托
//            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
//            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

//            int x = 100;
//            int y = 200;
//            int z = 0;

//            //z = func1.Invoke(x, y);
//            z = func1(x, y);
//            Console.WriteLine(z);
//            //z = func2.Invoke(x, y);
//            z = func2(x, y);
//            Console.WriteLine(z);
//        }
//    }
//    class Calculator
//    {
//        public void Report()
//        {
//            Console.WriteLine("I have 3 methods");
//        }
//        public int Add(int a, int b)
//        {
//            int result = a + b;
//            return result;
//        }
//        public int Sub(int a, int b)
//        {
//            int result = a - b;
//            return result;
//        }
//    }
//}


//namespace _2
//{
//    public delegate double Calc(double x,double y);//委托是一种类//C#中存在类的嵌套,所以也可以声明在类内,使用的时候Program.Calc
    
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            Calc calc1 = new Calc(calculator.Add);
//            Calc calc2 = new Calc(calculator.Sub);
//            Calc calc3 = new Calc(calculator.Mul);
//            Calc calc4 = new Calc(calculator.Div);

//            double a = 100;
//            double b = 200;
//            double c = 0;

//            //c = calc1.Invoke(a,b);
//            c = calc1(a, b);
//            Console.WriteLine(c);
//            c = calc2.Invoke(a, b);
//            Console.WriteLine(c);
//            c = calc3.Invoke(a, b);
//            Console.WriteLine(c);
//            c = calc4.Invoke(a, b);
//            Console.WriteLine(c);
//        }
//    }
//    class Calculator
//    {
//        public double Add(double x, double y)
//        {
//            return x + y;
//        }
//        public double Sub(double x, double y)
//        {
//            return x - y;
//        }
//        public double Mul(double x, double y)
//        {
//            return x * y;
//        }
//        public double Div(double x, double y)
//        {
//            return x / y;
//        }
//    }
//}

////回调
//namespace _3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ProductFactory productFactory = new ProductFactory();
//            WrapFactory wrapFactory = new WrapFactory();

//            Func<Product> func1 = new Func<Product>(productFactory.MakePizze);
//            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

//            Logger logger = new Logger();
//            Action<Product> log = new Action<Product>(logger.Log);

//            Box box1 = wrapFactory.WrapProduct(func1,log);
//            Box box2 = wrapFactory.WrapProduct(func2,log);

//            Console.WriteLine(box1.Product.Name);
//            Console.WriteLine(box2.Product.Name);
//        }
//    }
//    //Logger类记录程序运行状态
//    class Logger
//    {
//        public void Log(Product product)
//        {
//            Console.WriteLine("Product '{0}' created at {1}.Price is {2}",product.Name,DateTime.UtcNow,product.Price);
//        }
//    }
//    class Product
//    {
//        public string Name { get; set; }
//        public double Price { get; set; }

//    }
//    class Box
//    {
//        public Product Product { get; set; }
//    }
//    //包装工厂
//    class WrapFactory
//    {
//        public Box WrapProduct(Func<Product> getProduct,Action<Product>logCallback)
//        {
//            Box box = new Box();
//            Product product = getProduct.Invoke();
//            if (product.Price >= 50)
//            {
//                logCallback(product);
//            }
//            box.Product = product;
//            return box;
//        }
//    }
//    //工厂
//    class ProductFactory
//    {
//        public Product MakePizze()
//        {
//            Product product = new Product();
//            product.Name = "Pizza";
//            product.Price = 12;
//            return product;
//        }
//        public Product MakeToyCar()
//        {
//            Product product = new Product();
//            product.Name = "Toy Car";
//            product.Price = 100;
//            return product;
//        }
//    }
//}


//using System.Threading;

//namespace _4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
 
//        }
//    }
//    class Student
//    {
//        public int ID { get; set; }
//        public ConsoleColor PenColor { get; set; }
//        public void DoHomework
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.Forgroud
//            }
//        }
//    }
//}


//使用接口替代委托
namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Box box1 = wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }
    interface IProductFactory
    {
        Product Make();
    }
    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }
    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }
    }
    //包装工厂
    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }
}