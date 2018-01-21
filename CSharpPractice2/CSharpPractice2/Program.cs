using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that uses type conversion

namespace CSharpPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 167.98;
            int i;
            i = (int)k;

            int a = 45;
            double g = 7.2;
            float f = 120.7f;
            bool b = true;

            string text = "01234";
            int number = Convert.ToInt32(text);

            Console.WriteLine(i);
            Console.WriteLine(a.ToString());
            Console.WriteLine(g.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(text);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
