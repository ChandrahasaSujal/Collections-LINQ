using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericCollectionsDemo
    {
        public static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
