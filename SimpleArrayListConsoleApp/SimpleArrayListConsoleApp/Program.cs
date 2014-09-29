using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrayListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add(123);
            myList.Add("Harun");
            myList.Add(3454);

            foreach (var dataList in myList)
            {
              Console.WriteLine(dataList);  
            }
            Console.ReadKey();
        }
    }
}
