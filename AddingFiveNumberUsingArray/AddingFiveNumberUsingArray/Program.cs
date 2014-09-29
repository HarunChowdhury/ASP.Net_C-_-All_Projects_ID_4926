using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingFiveNumberUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[5];
           // int length = numbers.Length;
           // int inputNumber;
          int  sum=0;
            Console.WriteLine("Enter Input Number ");
            for (int i = 0; i < numbers.Length; i++)
            {
               //i= i + 1;
              numbers[i]=Convert.ToInt32(Console.ReadLine());
                sum = sum +numbers[i];

            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
