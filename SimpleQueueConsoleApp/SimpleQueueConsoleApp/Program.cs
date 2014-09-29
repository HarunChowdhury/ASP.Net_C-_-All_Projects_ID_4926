using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue=new Queue<int>();

            myQueue.Enqueue(123);
            myQueue.Enqueue(100);
            myQueue.Enqueue(450);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("\n\n Below Foreach Ans");

            //foreach (int dataQueue in myQueue)
            //{
            //    Console.WriteLine(dataQueue);
            //}

            Console.ReadKey();
        }
    }
}
