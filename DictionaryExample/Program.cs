using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    /// <summary>
    /// Dictionary<TKey,TValue>: provides a key value to access objects.
    /// 
    /// Allows you to access data using a unique key in a key/value pair.
    /// Does not provide sorting, but can be queried with LINQ and the results can be sorted.
    /// Methods:
    /// * Add
    /// * Remove
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dataStore = new Dictionary<int, string> {
                    {1, "R2-D2" },
                    {2, "C-3P0" }
            };           

            dataStore.Clear();
            dataStore.Add(55, "RoboCop");

            foreach (KeyValuePair<int, string> row in dataStore)
            {
                Console.WriteLine("Key: " + row.Key + " Value: " + row.Value);
            }

            if (dataStore.ContainsKey(55))
            {
                string value = dataStore[55];
                Console.WriteLine(value);
            }

            if (dataStore.ContainsValue("RoboCop"))
            {
                Console.WriteLine("RoboCop is present.");
            }

            Console.ReadKey();
        }
    }
}
