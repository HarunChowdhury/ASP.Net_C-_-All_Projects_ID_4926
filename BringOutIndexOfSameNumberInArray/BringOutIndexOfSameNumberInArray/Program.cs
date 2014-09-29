using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringOutIndexOfSameNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter Input Number");

           

            for (int insert = 0; insert < numbers.Length; insert++)
            {
                numbers[insert] =Convert.ToInt32( Console.ReadLine());
            }

           // Array.Sort(numbers);

           

            Console.Write("\nEnter Finding Value: ");
           int findValue=Convert.ToInt32(Console.ReadLine());
           // for (int find = 0; find < numbers.Length; find++)
          //  {

             

                for (int insert =0; insert < numbers.Length; insert++)
               {

                    if (numbers[insert] == findValue)
                    {
                        Console.WriteLine("Index of "+findValue+" is = "+Array.IndexOf(numbers,findValue ));

                       
                    }
                }

               // Console.WriteLine();
           // }

            Console.ReadKey();
        }
    }
}
