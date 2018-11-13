using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinqDemo3
    {
        public static void Main()
        {
            List<int> l1 = new List<int>() { 13, 56, 98, 24, 62, 52, 83, 78, 39, 42, 91, 86, 6, 73, 67, 48, 18, 29, 3, 32, 15, 21, 2 };
            var coll1 = from t in l1 where t < 40 orderby t select t;
            Console.WriteLine(string.Join(" ", coll1));


            int[] arr = { 13, 56, 98, 24, 62, 52, 83, 78, 39, 42, 91, 86, 6, 73, 67, 48, 18, 29, 3, 32, 15, 21, 2 };

            var brr = from s in arr where s > 40 orderby s descending select s;

            Console.WriteLine(string.Join(" ",brr));
            Console.ReadLine();
        }
    }
}
