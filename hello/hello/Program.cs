using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a string:");
            string inp = Console.ReadLine();
            Console.Write("Shalaka " + inp);

            Console.WriteLine(" Hello World");
            Console.ReadLine();
            */

            /* Variables
            Integer - int Harry = 34;  --> 4 bytes
            Long - long Harry --> 8 bytes 
            Floating point number - float a = 6.6F; --> 4 bytes
            Double double c = 6.6D; --> 8 bytes , D is not necessary
            Character - char b = 'B'; --> 2 bytes
            Boolean - bool isGreat = true; --> 1 bit only
            String - string inp = "Harry"; --> --> 2 bytes per character
             */

            /* Typecasting
            1. Implicit casting
            char -> int -> long -> float -> double
            example 1
            int x = 3;
            double y = x;

            example 2 
            int z = 'a'
            
            2. Explicit Casting
            int a = (int) 3.4;
            float b = (float) 3.412345678901245575756568341234665757574;
            
            3. using Convert
            float c = Convert.ToInt16(3.55);
            Convert.ToInt32
            Convert.ToInt64
            Convert.ToString
            char c = Convert.ToChar(67);

            string c = "4";
            Console.WriteLine(Convert.ToInt32(c) + 4);
            */

            /* Operators
            1. Arithematic Operators
            a + b, -, *, /, %

            2. Assignment Operators
            int a = 4
            int b = a
            b += 4
            b -= 3
            b *= 2
            b /= 6

            3. Logical Operators
            a && b
            a || b
            !a
            !false will give you true

            4. Comparison Operators
            Console.WriteLine(324 > 5);
            >= <= != ==
             */

            /* Math Class
            int a = Math.Max(34,54);
            double c = Math.Sqrt(545);
             */

            /* String
            string b = "Shalaka";
            int c = b.Length;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(b.ToUpper());
            Console.WriteLine(string.Concat(b, "hey"));
            */

            /* String interpolation (like format in Python)
            string name = "Shalaka";
            string candies = Console.ReadLine();
            Console.WriteLine($"Hey {name} you get {candies} candies");

            string name = "Shalaka this is C#";
            Console.WriteLine(name.IndexOf("this"));
            Console.WriteLine(name.Substring(2));

            *** Escape Sequence character using \ -> \" \n \t
            string name = "Shalaka this is \"C#\" and \t \"Python\"";
            Console.WriteLine(name);
             * 
             */

            /* if else ladder
            
            Console.WriteLine("Enter your age");
            string ageStr =  Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            if (age > 18)
            {
                Console.WriteLine("You can drive");
            }
            else if (age < 2)
            {
                Console.WriteLine("You are just born");
            }
            else
            {
                Console.WriteLine("You cannot drive");
            }
            */

            /*
            int age = 18;
            switch (age)
            {
                case 18:
                    Console.WriteLine("You are 18");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;

                default:
                    Console.WriteLine("Enjoy");
                    break;
            }
            */

            /* Loops in C#
            
            1. While Loops
            int i = 0;
            while (i<5)
            {
                Console.WriteLine(i);
                i += 1;
                // i++;
            }

            2. Do While
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i += 1;
                // i++;
            } 
            while (i > 5);

            3. For Loops
            continue
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hey");
                continue; // skip the next lines but continue the remaining iterations
                Console.WriteLine(i);
            }

            break
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hey");
                break; // leave the loop forever
                Console.WriteLine(i);
                
            }
             */

            // method overloading in C#
            Greet("Shalaka");

            Console.WriteLine(avg(10, 3, 7));

            float temp = avg(3, 4, 6);
            Console.WriteLine(temp);

            Console.WriteLine(avg(10, 5));

            // OOP in C# 
            Player Tommy = new Player();
            Console.WriteLine(Tommy.getHealth());

            Tommy.setHealth(30);
            Console.WriteLine(Tommy.getHealth());

            Console.ReadLine();
      
        }
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }
        static float avg(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }
        // let's see method overload (same name of method but different parameters)
        static int avg(int a, int b)
        {
            int sum = a + b;
            return sum / 2;
        }


    }
}

