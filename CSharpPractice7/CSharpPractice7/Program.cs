using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that uses conditional statements
namespace CSharpPractice7
{
    public enum Season
    {
        spring,
        summer,
        autumn,
        winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            if(i > j)
            {
                Console.WriteLine("i id greater than j");
                Console.ReadKey();
            }
            if(i < j)
            {
                Console.WriteLine("i is less than j");
                Console.ReadKey();
            }
            if(i == j)
            {
                Console.WriteLine("i equals j");
                Console.ReadKey();
            }
            int k = 20;
            int p = 30;
            if(k > p)
            {
                Console.WriteLine("i is greater than j");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("i is less than or equal to j");
                Console.ReadKey();
            }
            int f = 40;
            int y = 50;
            if(f > y)
            {
                Console.WriteLine("i is greater than j");
                Console.ReadKey();
            }
            else if(f < y)
            {
                Console.WriteLine("i is less than j");
                Console.ReadKey();
            }
            else if(f == y)
            {
                Console.WriteLine("i is equals to j");
                Console.ReadKey();
            }
            int c = 50;
            switch(c)
            {
                case 10:
                    Console.WriteLine("Value of x is 10.");
                    break;
                case 20:
                    Console.WriteLine("Value of x is 10.");
                    break;
                case 30:
                    Console.WriteLine("Value of x is 30.");
                    break;
                case 40:
                    Console.WriteLine("Value of x is 40.");
                    break;
                case 50:
                    Console.WriteLine("Value of x is 50.");
                    break;
                default:
                    Console.WriteLine("Unknown value.");
                    break;
            }
            var season = Season.autumn;
            switch(season)
            {
                case Season.autumn:
                    Console.WriteLine("The season is autumn");
                    break;
                    /*if you wanted to display the same message for two seasons
                    /then disregard the console.writeline and break*/
                case Season.summer:
                    Console.WriteLine("The season is summer.");
                    break;
                case Season.spring:
                    Console.WriteLine("The season is spring");
                    break;
                case Season.winter:
                    Console.WriteLine("The season is winter.");
                    break;
                default:
                    Console.WriteLine("Unknown season.");
                    break;
            }
        }
    }
}
