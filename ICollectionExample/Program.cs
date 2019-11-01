/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;
using System.Collections;

namespace ICollectionExample
{
    /// <summary>
    /// Allows a developer to use foreach to iterate.
    /// Is a child of the IEnumerable interface, so can be used with LINQ.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new RobotModels();
            foreach (string model in robots)
            {
                Console.WriteLine(model);
            }
            Console.ReadKey();
        }
    }

    class RobotModels : ICollection
    {
        // Array containing values in this collection
        string[] robomodels = { "Linguo", "T-1000", "Sonny", "Gerty" };

        // Count property to return the length of the collection
        public int Count
        {
            get { return robomodels.Length; }
        }

        // Returns an object that can be used to syncrhonise 
        // access to this object
        public object SyncRoot
        {
            get { return this; }
        }

        // Returns true if the collection is thread safe
        // This collection is not
        public bool IsSynchronized
        {
            get { return false; }
        }

        // Provide a copyto behavior
        public void CopyTo(Array array, int index)
        {
            foreach (string point in robomodels)
            {
                array.SetValue(point, index);
                index = index + 1;
            }
        }

        // Required for IEnumerate
        // Returns the enumerator from the embedded array
        public IEnumerator GetEnumerator()
        {
            return robomodels.GetEnumerator();
        }
    }
}
