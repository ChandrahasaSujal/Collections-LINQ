using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class DictionaryDemo
    {
        public static void Main()
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("Eno", 101);
            d.Add("Ename", "Scott");
            d.Add("Salary", 25000.36);

            foreach(string key in d.Keys)
            {
                Console.WriteLine(key + ": "+d[key]);
            }

            Console.WriteLine(d["Eno"]);

            d.Remove("Eno");

            foreach (string key in d.Keys)
            {
                Console.WriteLine(key + ": " + d[key]);
            }

            Console.ReadLine();
        }
    }
}
