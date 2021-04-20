using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        int num = 1;
        void Counting()
        {
            if (num == 11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Counting();

        }

        int a = 5;
        int result = 1;
        void Factorial()
        {
            if (a == 0)
            {
                Console.WriteLine(result);
                return;
            }
            result = result * a;
            a--;
            Factorial();
           
            
        }

        int b = 6;
        int result2 = 1;
        int Factorial2()
        {
            if (b == 0)
            {
                
                return 1;
            }
            result2 = result2 * b;
            b--;
            Factorial2();
            return result2;

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Counting();
            Console.ReadLine();

            
            obj.Factorial();
            Console.ReadLine();

            Console.WriteLine(obj.Factorial2());
            Console.ReadLine();

        }
    }
}
