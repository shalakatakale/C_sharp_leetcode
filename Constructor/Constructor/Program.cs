using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /*
    // Example Constructor
    class Program
    {
        public Program()
        {
            Console.WriteLine("I am Constructor");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.ReadLine();
        }
    }
    */

    /*
    // parameterized constructor example
    class Car
    {
        string carModel;
        int carYear;
        // parameterized constructor 
        public Car(string model, int year)
        {
            carModel = model;
            carYear = year;
            Console.WriteLine("This is a "+ carModel +" made in "+ carYear);
        }
        static void Main(string[] args)
        {
            Car obj = new Car("Ferrari", 2021);
            Console.WriteLine("My Car " + obj.carModel + " is made in " + obj.carYear);
            Console.ReadLine();
        }
    }
    */

    //  constructor overloading
    class Car
    {
        string carModel;
        int carYear;
        
        public Car(string model, int year)
        {
            carModel = model;
            carYear = year;
            
        }
        public Car(int year, string model) // sequence of int year and string model is changed 
        {
            carModel = model;
            carYear = year;

        }

        static void Main(string[] args)
        {
            Car obj = new Car("Ferrari", 2021);
            Console.WriteLine("My Car " + obj.carModel + " is made in " + obj.carYear);
            Car obj2 = new Car(2020, "Porsche");
            Console.WriteLine("My Car " + obj2.carModel + " is made in " + obj2.carYear);
            Console.ReadLine();
        }
    }


 }
