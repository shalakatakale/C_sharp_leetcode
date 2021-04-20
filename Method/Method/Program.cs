using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        public int FindMax(int num1 , int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program Max = new Program();
            Console.WriteLine(Max.FindMax(5, 7));
            int c = Max.FindMax(56, 89);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
