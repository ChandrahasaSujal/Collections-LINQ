using System;
using System.Collections;

namespace Collections
{
    class ArrayListDemo
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Hello");
            al.Add(100);
            al.Add(true);
            al.Add(31.25);
            al.Add(356.54f);

            al.Add(true);
            al.Insert(4, false);

            for (int i = 0; i < al.Count; i++)
                Console.WriteLine(al[i]);
            Console.WriteLine();
       
           // al.Remove(false);

            
            //for (int i = 0; i < al.Count; i++)
              //  Console.WriteLine(al[i]);
            //al.RemoveAt(0);
           // for (int i = 0; i < al.Count; i++)
             //   Console.WriteLine(al[i]);

            ArrayList coll = new ArrayList(al);


            foreach(object collection in coll )
            {
                Console.WriteLine(collection);
            }
            Console.ReadLine();
        }
    }
}
