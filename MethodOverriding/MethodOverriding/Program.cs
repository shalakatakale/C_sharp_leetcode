using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Animal
    {
        public void Eating()
        {
            Console.WriteLine("Animal is Eating");
        }
        
    }
    class Dog: Animal
    {
        public void Eating()
        {
            Console.WriteLine("Dog is Eating");
        }
        static void Main(string[] args)
        {
            Dog Bailey = new Dog();
            Bailey.Eating();
            Console.ReadLine();
        }
    }
}
