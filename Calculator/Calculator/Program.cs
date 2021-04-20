using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        // variables
        int num1;
        int num2;
        string str;
        int result;

        // method
        // a non static method (eg. DisplayResult) can be called in other non static method
        // in same class without creating an object
        void Add()
        {
            str = "addition";
            result = num1 + num2;
            DisplayResult();
        }
        void Subtract()
        {
            str = "subtraction";
            result = num1 - num2;
            DisplayResult();
        }

        // create DisplayResult so that you don't write Console.WriteLine(result);
        // Console.ReadLine(); again and again
        void DisplayResult()
        {
            Console.WriteLine(str+ " Result is : " + result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            // write new keyword to create obj and memory is allocated
            // After new we have to intialize and for that create constructor
            // to create constructor write class name and ()
            // here Calculator()
            Calculator obj = new Calculator();
            obj.num1 = 20;
            obj.num2 = 30;
            obj.Add();
            obj.Subtract();
                

            Calculator obj1 = new Calculator();
            obj1.num1 = 30;
            obj1.num2 = 5;
            obj1.Add();
            obj1.Subtract();
            
        }
        

    }
}
