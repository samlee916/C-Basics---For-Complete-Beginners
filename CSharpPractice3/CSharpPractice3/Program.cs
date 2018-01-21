using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# sharp program that uses operators

namespace CSharpPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //postfix increment
            int a = 1;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //prefix increment
            int c = 1;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            //arithmetic operators
            int e = 9;
            int f = 7;
            Console.WriteLine(e + f);
            Console.WriteLine((float)e / (float)f);
            //true of false operators
            int g = 9;
            int h = 3;
            Console.WriteLine(a > b);
            Console.WriteLine(a > b || a == b);




            Console.ReadKey();

        }
    }
}
