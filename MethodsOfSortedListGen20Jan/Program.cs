using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfSortedListGen20Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> slst = new SortedList<string, string>();

            // Add elements to the list. No duplicate keys allowed but values can be duplicate
            slst.Add("03", "Yuzvendra Chahal");
            slst.Add("07", "MS Dhoni");
            slst.Add("18", "Virat Kohli");
            slst.Add("25", "Shikhar Dhawan");
            slst.Add("33", "Hardik Pandya");
            slst.Add("45", "Rohit Sharma");
            slst.Add("48", "Suresh Raina");
            slst.Add("93", "Jasprit Bumrah");
            slst.Add("99", "Ravichandran Ashwin");
            foreach (KeyValuePair<string, string>kp in slst)
            {
                Console.WriteLine(kp.Key + " : " +kp.Value);
            }

            //Count
            Console.WriteLine("\nNumber of entries : "+ slst.Count);

            //Contains
            Console.WriteLine("If the key 18 is present? " + slst.Contains(new KeyValuePair<string, string>("18", "Virat Kohli")));

            //ContainsKey
            Console.WriteLine("\nIf the key 50 is present? " + slst.ContainsKey("50"));

            //ContainsValue
            Console.WriteLine("\nIf the value Suresh Raina is present? " + slst.ContainsValue("Suresh Raina"));

            //Remove
            slst.Remove("25");
            Console.WriteLine("\nAfter removing key 25");

            //GetEnumerator
            var ide = slst.GetEnumerator();
            while(ide.MoveNext())
            {
                Console.WriteLine(ide.Current);
            }

            //RemoveAt
            slst.RemoveAt(4);//index
            Console.WriteLine("\nAfter removing values at index 4");
            var ide2 = slst.GetEnumerator();
            while (ide2.MoveNext())
            {
                Console.WriteLine(ide2.Current);
            }

            //IndexOfKey
            Console.WriteLine("\nIndex of key 99 : " + slst.IndexOfKey("99"));

            //IndexOfValue
            Console.WriteLine("\nIndex of value MS Dhoni : " + slst.IndexOfValue("MS Dhoni"));

            //Clear
            slst.Clear();
            Console.WriteLine("\nAfter using Clear method");
            var cl = slst.GetEnumerator();
            while (cl.MoveNext())
            {
                Console.WriteLine(cl.Current);
            }
            Console.ReadLine();
        }
    }
}
