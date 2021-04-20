using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Price: " + price);
        }

    }

    class Maruti : Car
    {
        public float mileage;

        public void printMileage()
        {
            Console.WriteLine("Mileage: " + mileage);
        }
        
    }
    class Ferrari: Car
    {
        public float speed;

        public void printMileage()
        {
            Console.WriteLine("Speed: " + speed);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model = "Alto";
            myCar.color = "White";
            myCar.price = 10000000;
            myCar.mileage = 22.5f;
            myCar.PrintCarInformation();
            myCar.printMileage();
            Console.ReadLine();
        }
    }
}


