using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueDemo
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(100);
            q.Enqueue("Hello");
            q.Enqueue(true);

            foreach (object obj in q)
                Console.WriteLine(obj +" ");
            q.Dequeue();

            foreach (object obj in q)
                Console.WriteLine(obj + " ");

            q.Enqueue("Home");
            foreach (object obj in q)
                Console.WriteLine(obj + " ");
            Console.ReadLine();
            
        }
    }
}
