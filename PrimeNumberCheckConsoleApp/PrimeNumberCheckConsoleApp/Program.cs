using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheckConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(number + "is my number");  int n= Math.Sqrt()
           // int number = Convert.ToInt32(a);
            bool flag = true;
            if (number==1)
            {
                Console.WriteLine(number+" is Not prime");

            }

            if (number==2)
            {
                Console.WriteLine(number + " is  prime");

            }

           
            for (int i = 2; i <number; i++)
                {
                    if ((number%i) == 0)
                    {
                       
                        flag = false;
                        break;


                    }


                }
            


            if (flag == false)
            {
                Console.WriteLine(number + " is not Prime Number.");
            }
            else
            {
                Console.WriteLine(number + " is prime.");
            }

           
            Console.ReadKey();
        }
    }
}
