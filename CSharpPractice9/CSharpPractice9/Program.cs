using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A C# program that shows inheritance
namespace CSharpPractice9
{
    public class Animal
    {
        public /*virtual*/ void Greet()
        {
            Console.WriteLine("Hi, I am an animal!!!");
            Console.ReadKey();
        }
    }
    public class Dog : Animal
    {
        /*public virtual void Greet()
        {
            Console.WriteLine("Hi, I am a dog!!!");
            Console.ReadKey();
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();
            Dog dog = new Dog();
            dog.Greet();
        }
    }
}
