using System;
using System.Collections;

namespace Collections
{
   class HashTable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eno", 1001);
            ht.Add("Name", "Scott");
            ht.Add("Salary", 45000);


            foreach (object obj in ht.Keys)
                Console.WriteLine(obj +":"+ ht[obj]);
            Console.ReadLine();
            
        }
    }
}
