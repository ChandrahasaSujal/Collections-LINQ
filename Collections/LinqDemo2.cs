using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinqDemo2
    {
        public static void Main()
        {
            int[] a = { 13, 56, 98, 24, 62, 52, 83, 78, 39, 42, 91, 86, 6, 73, 67, 48, 18, 29, 3, 32, 15, 21, 2 };
            int count = 0;
            int index = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > 40)
                    count++;
            }

            int[] b=new int[count];

            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > 40)
                { 
                    b[index] = a[i];
                    index++;
                }
            }

            Console.WriteLine(string.Join(" ", b));
            Console.ReadLine();
        }
    }
}
