using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that uses loops
namespace CSharpPractice8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
                Console.ReadKey();
            }
            int number1 = 6;
            do
            {
                Console.WriteLine(number);
                number++;
                Console.ReadKey();

            }
            while (number < 10);
            int num = 15;
            for (int i = 10; i < num; i++)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
            string[] array = new string[] { "Jack", "Sam", "James", "Leo", "John" };
            foreach(string s in array)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
        }
    }
}
