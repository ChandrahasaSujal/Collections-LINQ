using System;
using System.Collections;

namespace Collections
{
    class CapacityCollectionConstructor
    {
        static void Main()
        {
            ArrayList al = new ArrayList(2);
            Console.WriteLine("Intial Capacity "+al.Capacity);

            al.Add(11);
            al.Add(11);
            al.Add(11);
            al.Add(11);
            al.Add(11);

            Console.WriteLine("Capacity after adding first element " + al.Capacity);


            ArrayList li = new ArrayList();


            li.AddRange(al);
            Console.WriteLine("Capacity after copying " + al.Capacity);
            Console.ReadLine();
        }
    }
}
