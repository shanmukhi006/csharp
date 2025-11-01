using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int harry = 23;
            ////Console.WriteLine("HelloWorld" + harry);
            ////Console.Write("I am Shanmukhi");//same line
            ////Console.WriteLine("I love c#");
            ////Console.ReadLine();

            ////typecasting
            //// int a = (int)3.5;
            ////Console.WriteLine(a);

            ////1.Implicit typecasting
            //int a = 3;
            //double b = a;
            //int c = 'y';
            ////int z = b;//not possible bcoz opposite not possible in implicit

            ////2.explicit typecasting
            //int x = (int)4.8;


            ////3.datatype conversion
            //float g = 8.3f;
            //Console.WriteLine(Convert.ToInt32(g));
           


            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);//121 gives ASCII Value
            //Console.ReadLine();



            ////4.Taking input from the user
            //Console.WriteLine("Enter your name");
            //String name = Console.ReadLine();
            //Console.WriteLine(name);
            //String xy= Console.ReadLine();
            //Console.WriteLine((Convert.ToInt32(xy)+4));

            //Console.ReadLine();

            ////5.MathClass
            //int l = Math.Max(3, 56);
            //Console.WriteLine(l);
            //Console.ReadLine();

            //int m = Math.Min(3, 56);
            //Console.WriteLine(m);
            //Console.ReadLine();

            //double n = Math.Sqrt(3);//double only
            //Console.WriteLine(n);
            //Console.ReadLine();

            //int o = Math.Abs(- 56);//absolute value
            //Console.WriteLine(o);
            //Console.ReadLine();


            //6.string methods
            Console.WriteLine("Enter your name");
            String name1 = Console.ReadLine();
            //Console.WriteLine(name1);
            Console.WriteLine(name1.ToUpper());//1st method
            Console.WriteLine(name1.ToLower());//2nd method
            Console.WriteLine(name1.Length);//3rd method
            Console.WriteLine(name1 + "meaning is god's name");//concatenation
            Console.WriteLine(string.Concat(name1, "meaning is god name"));//concatenation method 2

            //string interpolation
            string name2=Console.ReadLine();
            Console.WriteLine($"My name is {name1}. His name is {name2}");
           

            //string accessing
            string name3=Console.ReadLine();
            Console.WriteLine(name3[5]);

            //string accessing through IndexOf
            string name4 = "Balabhadrapatruni Uma Shanmukhi";
            Console.WriteLine(name4.IndexOf("Uma"));

            //Substring
            string name5 = "Hello Ramu";
            Console.WriteLine(name5.Substring(2));
          
            Console.ReadLine();








        }
    }
}
