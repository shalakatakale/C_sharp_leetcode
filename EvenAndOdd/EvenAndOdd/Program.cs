using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =0; i <= 100; i++)
            {
                if (i%2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
