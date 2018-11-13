using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinqDemo4
    {
        static void Main()
        {
            string[] colors = { "Red", "Blue", "Green", "White", "Black", "Yellow", "Pink", "Orange" };

            // var str = from t in colors select t; //Accessing  all the colors from collection
            //foreach(var s in str)
            //{
            //    Console.WriteLine(s);
            //}

            //var str = from t in colors where t.Length == 5 select t;   //Accessing colors having exact characters in the given collection.

            //var str = from s in colors where s.StartsWith("R") select s;      // Accesing the elements of a collection whose elements starts  with R.

            //var str = from s in colors where s.Substring(0,1) == "R" select s; // Accessing the elements of a collection starts with a letter R by making use of Substring mehtod.

            //var str = from s in colors where s.EndsWith("e")  select s;   // Ends with letter e in a given collection.

            var str = from s in colors where s.IndexOf("e") == -1 select s;

            Console.WriteLine(string.Join(" ", str));
            Console.ReadLine();
        }
    }
}
