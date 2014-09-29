using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHashTableConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashTable=new Hashtable();
            aHashTable.Add(1,678878);
            aHashTable.Add(2,0000);
            aHashTable.Add(3, 77777);
            aHashTable.Add(4, 5555555);

            int aCoresNAme = (int) aHashTable[3];

            Console.WriteLine(aCoresNAme);
            Console.WriteLine("\n");
            Dictionary<string ,string > data=new Dictionary<string, string>();

            data.Add("102","Harun");
            data.Add("103", "Munna");
            string dic = (string)data["102"];
            Console.WriteLine(dic);

            Console.ReadKey();
        }

        
        
    }
}
