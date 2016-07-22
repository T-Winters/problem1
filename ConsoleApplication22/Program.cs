using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {

            string strNum1, strNum2;
            int num1, num2;
            int i = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Enter your first number: ");
                strNum1 = (Console.ReadLine().ToLower());
                num1 = int.Parse(strNum1);
                Console.WriteLine("Your Total is: " + num1);
                Console.WriteLine("Would you like to enter another number?");
                string repeat = (Console.ReadLine().ToLower());

                while (repeat == "yes")
                {

                    if (repeat == "yes")
                    {
                        Console.WriteLine("Enter your next number: ");
                        strNum2 = (Console.ReadLine().ToLower());
                        num2 = int.Parse(strNum2);
                        sum = num2;
                        i++;

                        sum = (num1 + num2 + sum);
                        Console.WriteLine("Your total is: {0} {1}", i, sum); ;
                    }
                    else
                    {
                        Console.WriteLine("GOODBYE...");
                    }
                }
            
            

        }
    }
}
