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
//            //(new Form()).Text = "xxxx";
//            //(new Form()).ShowDialog();
//            //-
//            //form-引用变量
//            //new Form()-实例
//            //Form form;
//            //form = new Form();
//            //form.Text = "xxx";
//            //form.ShowDialog();
//            //-
//            Form form1;
//            Form form2;
//            form1 = new Form();
//            form2 = form1;
//            form1.Text = "xxx";
//            form2.ShowDialog();
//        }
//    }
//}


////
//namespace _1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator c = new Calculator();
//            string str = c.Today();
//            Console.WriteLine(str);
//        }
//    }
//    class Calculator
//    {
//        public string Today()
//        {
//            int day = DateTime.Now.Day;
//            return day.ToString();
//        }
//    }
//}



namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.SumFrom1ToX3(3);
            Console.WriteLine(result);
        }
    }
    class Calculator
    {
        public int SumFrom1ToX1(int x)
        {
            int result = 0;
            for (int i = 1; i < x + 1; i++)
            {
                result = result + i;
            }
            return result;
        }
        public int SumFrom1ToX2(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + SumFrom1ToX2(x - 1);
                return result;
            }
        }
        public int SumFrom1ToX3(int x)
        {
            return (1 + x) * x / 2;
        }
    }
}