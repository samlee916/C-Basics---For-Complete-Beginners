using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that uses enums
namespace CSharpPractice6
{
    public enum Weekdays
    {
        //you can also just ignore the 0-6, since it automatically starts at 0
        //if you have Monday be 110, then the rest will be 
        Monday,//Monday = 110;
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Weekdays.Friday);
            Console.WriteLine((int)Weekdays.Friday);
            Console.ReadKey();
        }
    }
}
