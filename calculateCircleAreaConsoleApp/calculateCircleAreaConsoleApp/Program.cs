using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateCircleAreaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius Valu of Circle : ");
           int radius=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Circle Area : "+Math.PI*radius*radius);
            Console.ReadKey();

        }
    }
}
