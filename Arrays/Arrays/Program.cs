using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array
            string[] cars = new string[4] {"Ferrari","Volkswagen","BMW","Audi"};
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[0].IndexOf("r"));
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach(string car in cars)
            {
                Console.WriteLine("foreach loop  " +car);

            }
            // list
            List<string> names = new List<string>();
            names.Add("Maruti");
            names.Add("Audi");
            names.Add("Ferrari");
            names.Add("Ford");
            names.Add("BMW");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("List: "+ names[i]);
            }
            foreach (string car in names)
            {
                Console.WriteLine("List foreach loop: "+car);
            }

            Console.ReadLine();


        }
    }
}
