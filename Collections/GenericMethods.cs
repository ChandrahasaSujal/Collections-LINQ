using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericMethods
    {
        public bool AreEqual<T>(T a,T b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
        static void Main()
        {
            GenericMethods a = new GenericMethods();
            Console.WriteLine(a.AreEqual<int>(10,10));
            GenericMethods b = new GenericMethods();
            Console.WriteLine(b.AreEqual<string>("Hello", "Hello"));

           Console.ReadLine();
        }

    }
}
