using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class TestGenericClass<T>
    {
        public bool AreEqual(T a, T b)
        {
            return a.Equals(b);
        }
    }
    class GenericMethodDemo
    {
        static void Main()
        {
            TestGenericClass<string> g = new TestGenericClass<string>();
            //bool res=g.AreEqual<int>(10,10);
            bool res = g.AreEqual("Hello", "Hello");
            if (res)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            TestGenericClass<int> i = new TestGenericClass<int>();
            i.AreEqual(10, 10);

            Console.ReadLine();
        }
    }
}
