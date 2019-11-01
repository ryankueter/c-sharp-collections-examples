/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */
using System;

namespace ArrayExample
{
    /// <summary>
    /// Elements in an array may be accessed using an index, or subscript value.
    /// Implement the IEnumerable interface so they can be iterated with foreach.
    /// You must decide in advance how many items will be stored in the array.
    /// Provides sorting.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization example
            int[] a = { 1, 2, 3, 4 };

            // Array of integers
            int[] a1 = new int[4];

            a1[0] = 1; 
            a1[1] = 2;
            a1[2] = 3;
            a1[3] = 4;

            // Use an index to work through the array     
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine(a1[i]);
            }

            // Initialize a new array
            a1 = new int[] { 1, 2, 3, 4 };

            // Use a foreach to work through the array
            foreach (int i in a1)
            {
                Console.WriteLine(i);
            }

            string[,] Robots = new string[3, 3]
            {
                { "RoboCop","Terminator","Bender" },
                { "Mega Man", "T-1000", "HAL 9000" },
                { "Optimus Prime", "R2-D2", "C-3P0" }
            };

            Console.WriteLine(Robots[0, 0]);  // RoboCop
            Console.WriteLine(Robots[2, 2]);  // C-3P0

            Console.ReadKey();
        }
        public void Init()
        {
            
        }

    }
}
