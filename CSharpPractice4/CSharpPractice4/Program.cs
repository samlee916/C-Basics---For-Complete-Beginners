using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that uses classes

namespace CSharpPractice4
{
    public class Calculator
    {
        public int Addition(int a, int b)
        //public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
    public class Person
    {
        public string firstname;
        public string lastname;
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + firstname + " " + lastname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstname = "Steve";
            person.lastname = "Austin";
            person.Introduce();
            Calculator mycalculator = new Calculator();
            //using static int:
            //int result = Calculator.Addition(5, 9)
            //Console.WriteLine(result);
            mycalculator.Addition(5, 9);
            int result = mycalculator.Addition(5, 9);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
