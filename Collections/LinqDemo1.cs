using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinqDemo1
    {
       public static void Main()
        {
            List<int> li1 = new List<int>() { 13, 56, 98, 24, 62, 52, 83, 78, 39, 42, 91, 86, 6, 73, 67, 48, 18, 29, 3, 32, 15, 21, 2 };

            List<int> li2 = new List<int>();

            foreach(int li in li1)
            {
                if (li > 40)
                    li2.Add(li);
            }


            li2.Sort();

            li2.Reverse();

            Console.WriteLine(string.Join(" ", li2));

            Console.ReadLine();
        }
    }
}
