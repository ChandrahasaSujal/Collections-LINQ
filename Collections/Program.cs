using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(100);
            s.Push("Hello");
            s.Push(true);
            s.Push(12.34);

            Console.WriteLine("Number of elements in the stack: "+s.Count);
            foreach (object item in s)
                Console.WriteLine(item);
            Console.WriteLine("Removed Element:"+s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine("Peek Element:" + s.Peek());
            foreach (object item in s)
                Console.WriteLine(item);
            Console.WriteLine("Number of elements in the stack: " + s.Count);


            foreach (object item in s)
                Console.WriteLine(item);
            Console.WriteLine("Number of elements in the stack: " + s.Count);

            Console.ReadLine();
        }
    }
}
