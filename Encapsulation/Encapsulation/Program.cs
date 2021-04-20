using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // Encapsulation example
    class Program
    {
        class Account
        {
            // step 1 make private variables
            int AccountBalance = 100; 
            
            /*
            // make public getter and setter methods
            public void setBalance(int amount)
            {
                AccountBalance = amount;
            }
            public void getBalance()
            {
                Console.WriteLine("Your account balance is " +AccountBalance);
            }
            */


            // C# Property is a combination of variable and method
            // - inbuilt set and get method
            public int Balance
            {
                set 
                {
                    if (value < 0)
                    {
                        Console.WriteLine("You cannot give negative value");
                    }
                    else
                    {
                        AccountBalance = value;
                    }

                }
                get
                {
                    return AccountBalance;
                }
            }

        }

        static void Main(string[] args)
        {
            Account myAccount = new Account();
            //myAccount.setBalance(10000);
            //myAccount.getBalance();
            myAccount.Balance = 50000;
            Console.WriteLine("Your account balance is "+ myAccount.Balance);
            Console.ReadLine();

        }
    }
}
